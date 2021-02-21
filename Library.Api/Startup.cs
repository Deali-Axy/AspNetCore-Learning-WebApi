using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Api.Entities;
using Library.Api.Services;
using Library.Api.Services.Impl;
using Library.Api.Services.Mock;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;

namespace Library.Api {
    public class Startup {
        public Startup(IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services) {
            services.AddControllers()
                .AddNewtonsoftJson();

            // Swagger Doc
            services.AddSwaggerGen(c => {
                c.SwaggerDoc("v1", new OpenApiInfo {
                    Title = "Library API",
                    Version = "v1"
                });
            });
            
            // EF Core
            services.AddDbContext<LibraryDbContext>(option => {
                option.UseSqlite(Configuration.GetConnectionString("SQLite"));
            });

            // 仓储包装器
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
            
            services.AddScoped<IAuthorMockRepository, AuthorMockRepository>();
            services.AddScoped<IBookMockRepository, BookMockRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            // swagger 中间件
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Library Api v1"));

            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }
}