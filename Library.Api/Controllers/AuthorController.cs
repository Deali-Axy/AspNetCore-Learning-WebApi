using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Library.Api.Entities;
using Library.Api.Helpers;
using Library.Api.Models;
using Library.Api.Services;
using Library.Api.Services.Mock;
using Microsoft.AspNetCore.Mvc;

namespace Library.Api.Controllers {
    [ApiController]
    [Route("api/authors")]
    public class AuthorController : ControllerBase {
        private readonly IRepositoryWrapper _repositoryWrapper;
        private readonly IMapper _mapper;

        public AuthorController(IRepositoryWrapper repositoryWrapper, IMapper mapper) {
            _repositoryWrapper = repositoryWrapper;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<AuthorDto>>> GetAuthorsAsync(
            [FromQuery] AuthorResourceParameters parameters
        ) {
            var authors = (await _repositoryWrapper.Author.GetAllAsync())
                // 实现分页功能
                .Skip(parameters.PageSize * (parameters.PageNumber-1))
                .Take(parameters.PageSize)
                // 根据作者名称排序
                .OrderBy(author => author.Name);
            var authorDtoList = _mapper.Map<IEnumerable<AuthorDto>>(authors);
            return authorDtoList.ToList();
        }

        [HttpGet("{authorId}", Name = nameof(GetAuthorAsync))]
        public async Task<ActionResult<AuthorDto>> GetAuthorAsync(Guid authorId) {
            var author = await _repositoryWrapper.Author.GetByIdAsync(authorId);
            if (author == null) return NotFound();

            return _mapper.Map<AuthorDto>(author);
        }

        [HttpPost]
        public async Task<ActionResult> CreateAuthorAsync(AuthorForCreationDto authorForCreationDto) {
            var author = _mapper.Map<Author>(authorForCreationDto);
            _repositoryWrapper.Author.Create(author);
            var result = await _repositoryWrapper.Author.SaveAsync();
            if (!result) throw new Exception("创建资源 Author 失败");

            var authorCreated = _mapper.Map<AuthorDto>(author);
            return CreatedAtRoute(nameof(GetAuthorAsync), new {authorId = authorCreated.Id}, authorCreated);
        }

        [HttpDelete("{authorId}")]
        public async Task<ActionResult> DeleteAuthorAsync(Guid authorId) {
            var author = await _repositoryWrapper.Author.GetByIdAsync(authorId);
            if (author == null) return NotFound();

            _repositoryWrapper.Author.Delete(author);
            var result = await _repositoryWrapper.Author.SaveAsync();
            if (!result) throw new Exception("删除资源 Author 失败");

            return NoContent();
        }
    }
}