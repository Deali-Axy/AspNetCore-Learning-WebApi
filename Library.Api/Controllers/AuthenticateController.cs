using System;
using System.Collections;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Library.Api.Entities;
using Library.Api.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using JwtRegisteredClaimNames = Microsoft.IdentityModel.JsonWebTokens.JwtRegisteredClaimNames;

namespace Library.Api.Controllers {
    [ApiController]
    [Route("auth")]
    public class AuthenticateController : ControllerBase {
        private readonly RoleManager<Role> _roleManager;
        private readonly UserManager<User> _userManager;
        private readonly IConfiguration _configuration;

        public AuthenticateController(RoleManager<Role> roleManager, UserManager<User> userManager, IConfiguration configuration) {
            _roleManager = roleManager;
            _userManager = userManager;
            _configuration = configuration;
        }

        [HttpPost("token", Name = nameof(GenerateToken))]
        public IActionResult GenerateToken(LoginUser loginUser) {
            if (loginUser.UserName != "demouser"
                || loginUser.Password != "demopassword") {
                return Unauthorized();
            }

            var claims = new List<Claim> {
                new Claim(JwtRegisteredClaimNames.Sub, loginUser.UserName)
            };
            var tokenConfigSection = _configuration.GetSection("Security:Token");
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(tokenConfigSection["Key"]));
            var signCredential = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var jwtToken = new JwtSecurityToken(
                issuer: tokenConfigSection["Issuer"],
                audience: tokenConfigSection["Audience"],
                claims: claims,
                expires: DateTime.Now.AddMinutes(3),
                signingCredentials: signCredential);
            return Ok(new {
                token = new JwtSecurityTokenHandler().WriteToken(jwtToken),
                expiration = TimeZoneInfo.ConvertTimeFromUtc(jwtToken.ValidTo, TimeZoneInfo.Local)
            });
        }


        [HttpPost("register", Name = nameof(AddUserAsync))]
        public async Task<IActionResult> AddUserAsync(RegisterUser registerUser) {
            var user = new User {
                UserName = registerUser.UserName,
                Email = registerUser.Email,
                BirthDate = registerUser.BirthDate
            };
            var result = await _userManager.CreateAsync(user, registerUser.Password);
            if (result.Succeeded) return Ok();

            ModelState.AddModelError("Error", result.Errors.FirstOrDefault()?.Description);
            return BadRequest(ModelState);
        }

        [HttpPost("token2", Name = nameof(GenerateTokenAsync))]
        public async Task<IActionResult> GenerateTokenAsync(LoginUser loginUser) {
            var user = await _userManager.FindByEmailAsync(loginUser.UserName);
            if (user == null) {
                return Unauthorized();
            }

            var result = _userManager.PasswordHasher.VerifyHashedPassword(user,
                user.PasswordHash,
                loginUser.Password);
            if (result != PasswordVerificationResult.Success) {
                return Unauthorized();
            }

            var userClaims = await _userManager.GetClaimsAsync(user);
            var userRoles = await _userManager.GetRolesAsync(user);
            foreach (var roleItem in userRoles) {
                userClaims.Add(new Claim(ClaimTypes.Role, roleItem));
            }

            var claims = new List<Claim> {
                new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Email, user.Email)
            };
            claims.AddRange(userClaims);

            var tokenConfigSection = _configuration.GetSection("Security:Token");
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(tokenConfigSection["Key"]));
            var signCredential = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var jwtToken = new JwtSecurityToken(
                issuer: tokenConfigSection["Issuer"],
                audience: tokenConfigSection["Audience"],
                claims: claims,
                expires: DateTime.Now.AddMinutes(3),
                signingCredentials: signCredential);
            return Ok(new {
                token = new JwtSecurityTokenHandler().WriteToken(jwtToken),
                expiration = TimeZoneInfo.ConvertTimeFromUtc(jwtToken.ValidTo, TimeZoneInfo.Local)
            });
        }
    }
}