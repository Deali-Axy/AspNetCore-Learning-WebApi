using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Api.Entities;
using Library.Api.Filters;
using Library.Api.Middlewares;
using Library.Api.Services;
using Library.Api.Services.Impl;
using Library.Api.Services.Mock;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;

namespace Library.Api {
    public class Startup {
        public Startup(IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services) {
            services.AddControllers(config => {
                config.Filters.Add<JsonExceptionFilter>();
                // 添加缓存配置
                config.CacheProfiles.Add("Default",
                    new CacheProfile {
                        Duration = 60
                    });
                config.CacheProfiles.Add("Never",
                    new CacheProfile {
                        Location = ResponseCacheLocation.None,
                        NoStore = true
                    });
            }).AddNewtonsoftJson();

            services.AddAutoMapper(typeof(Startup));

            // Identity服务
            services.AddIdentity<User, Role>()
                .AddEntityFrameworkStores<LibraryDbContext>();

            // JwtBearer认证
            // services.AddAuthentication(defaultScheme: JwtBearerDefaults.AuthenticationScheme)
            //     .AddCookie()
            //     .AddJwtBearer();
            var tokenSection = Configuration.GetSection("Security:Token");
            services.AddAuthentication(options => {
                    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                })
                .AddJwtBearer(options => {
                    options.TokenValidationParameters = new TokenValidationParameters {
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidateIssuer = true,
                        ValidateIssuerSigningKey = true,
                        ValidIssuer = tokenSection["Issuer"],
                        ValidAudience = tokenSection["Audience"],
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(tokenSection["Key"])),
                        ClockSkew = TimeSpan.Zero
                    };
                });

            // 响应缓存
            services.AddResponseCaching(options => {
                options.UseCaseSensitivePaths = true;
                options.MaximumBodySize = 1024;
            });

            // Swagger Doc
            services.AddSwaggerGen(c => {
                c.SwaggerDoc("v1", new OpenApiInfo {
                    Title = "Library API",
                    Version = "v1"
                });
            });

            // EF Core
            services.AddDbContext<LibraryDbContext>(
                option => option.UseSqlite(
                    Configuration.GetConnectionString("SQLite"),
                    builder => builder.MigrationsAssembly(typeof(Startup).Assembly.GetName().Name)
                ));

            // 仓储包装器
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();

            // 过滤器
            services.AddScoped<CheckAuthorExistFilterAttribute>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
            }

            app.UseMiddleware<PrintRequestMiddleware>();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            // swagger 中间件
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Library Api v1"));

            // 相应缓存中间件
            app.UseResponseCaching();
            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }
}