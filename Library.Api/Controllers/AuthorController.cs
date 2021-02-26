using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Library.Api.Entities;
using Library.Api.Filters;
using Library.Api.Helpers;
using Library.Api.Models;
using Library.Api.Services;
using Library.Api.Services.Mock;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Net.Http.Headers;
using Newtonsoft.Json;

namespace Library.Api.Controllers {
    [ApiController]
    [Authorize]
    [Route("api/authors")]
    public class AuthorController : ControllerBase {
        private readonly IRepositoryWrapper _repositoryWrapper;
        private readonly IMapper _mapper;
        private readonly ILogger<AuthorController> _logger;

        public AuthorController(IRepositoryWrapper repositoryWrapper,
            IMapper mapper,
            ILogger<AuthorController> logger
        ) {
            _repositoryWrapper = repositoryWrapper;
            _mapper = mapper;
            _logger = logger;
        }

        private AuthorDto CreateLinksForAuthor(AuthorDto author) {
            author.Links.Clear();
            author.Links.Add(new Link {
                Method = HttpMethods.Get,
                Href = "self",
                Relation = Url.Link(nameof(GetAuthorAsync), new {authorId = author.Id})
            });
            author.Links.Add(new Link {
                Method = HttpMethods.Delete,
                Href = "delete author",
                Relation = Url.Link(nameof(DeleteAuthorAsync), new {authorId = author.Id})
            });
            author.Links.Add(new Link {
                Method = HttpMethods.Get,
                Href = "author's book",
                Relation = Url.Link(nameof(BookController.GetBooksAsync), new {authorId = author.Id})
            });
            return author;
        }

        /// <summary>
        /// 为资源集合本身添加链接列表
        /// </summary>
        /// <param name="authors"></param>
        /// <param name="parameters"></param>
        /// <param name="paginationData"></param>
        /// <returns></returns>
        private ResourceCollection<AuthorDto> CreateLinksForAuthors(
            ResourceCollection<AuthorDto> authors,
            AuthorResourceParameters parameters = null,
            dynamic paginationData = null
        ) {
            authors.Links.Clear();
            authors.Links.Add(new Link {
                Method = HttpMethods.Get,
                Href = "self",
                Relation = Url.Link(nameof(GetAuthorsAsync), parameters)
            });
            authors.Links.Add(new Link {
                Method = HttpMethods.Post,
                Href = "create author",
                Relation = Url.Link(nameof(CreateAuthorAsync), null)
            });
            if (paginationData != null) {
                if (paginationData.previousPageLink != null)
                    authors.Links.Add(new Link {
                        Method = HttpMethods.Get,
                        Href = "previous page",
                        Relation = paginationData.previousePageLink
                    });

                if (paginationData.nextPageLink != null)
                    authors.Links.Add(new Link {
                        Method = HttpMethods.Get,
                        Href = "next page",
                        Relation = paginationData.nextPageLink
                    });
            }

            return authors;
        }

        [AllowAnonymous]
        [HttpGet(Name = nameof(GetAuthorsAsync))]
        [ResponseCache(CacheProfileName = "Default", VaryByQueryKeys = new[] {"sortBy", "searchQuery"})]
        public async Task<ActionResult<ResourceCollection<AuthorDto>>> GetAuthorsAsync(
            [FromQuery] AuthorResourceParameters parameters
        ) {
            _logger.LogInformation(nameof(GetAuthorsAsync));
            var pagedList = await _repositoryWrapper.Author.GetAllAsync(parameters);

            var paginationMetadata = new {
                totalCount = pagedList.TotalCount,
                pageSize = pagedList.PageSize,
                currentPage = pagedList.CurrentPage,
                totalPages = pagedList.TotalPages,
                previousPageLink = pagedList.HasPrevious
                    ? Url.Link(nameof(GetAuthorsAsync), new {
                        pageNumber = pagedList.CurrentPage - 1,
                        pageSize = pagedList.PageSize,
                        birthPlace = parameters.BirthPlace,
                        searchQuery = parameters.SearchQuery,
                        sortBy = parameters.SortBy,
                    })
                    : null,
                nextPageLink = pagedList.HasNext
                    ? Url.Link(nameof(GetAuthorsAsync), new {
                        pageNumber = pagedList.CurrentPage + 1,
                        pageSize = pagedList.PageSize,
                        birthPlace = parameters.BirthPlace,
                        searchQuery = parameters.SearchQuery,
                        sortBy = parameters.SortBy,
                    })
                    : null
            };
            Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(paginationMetadata));

            var authorDtoList = _mapper.Map<IEnumerable<AuthorDto>>(pagedList);
            // 为集合中的每一个资源添加链接列表
            authorDtoList = authorDtoList.Select(CreateLinksForAuthor);
            var resourceList = new ResourceCollection<AuthorDto> {
                Items = authorDtoList.ToList()
            };
            return CreateLinksForAuthors(resourceList, parameters, paginationMetadata);
        }

        /// <summary>获取作者信息</summary>
        /// <remarks>
        ///     通过ResponseCache特性的Location属性设置缓存的位置
        ///     <code>
        ///         Any: 设置Cache-Control的值为 public
        ///         Client: private
        ///         None: no-cache
        ///     </code>
        /// </remarks>
        /// <param name="authorId">作者ID</param>
        /// <returns></returns>
        [HttpGet("{authorId}", Name = nameof(GetAuthorAsync))]
        [ResponseCache(Duration = 60, Location = ResponseCacheLocation.Client)]
        public async Task<ActionResult<AuthorDto>> GetAuthorAsync(Guid authorId) {
            var author = await _repositoryWrapper.Author.GetByIdAsync(authorId);
            if (author == null) return NotFound();

            // 检查author是否被修改
            var entityHash = HashFactory.GetHash(author);
            Response.Headers[HeaderNames.ETag] = entityHash;
            if (Request.Headers.TryGetValue(HeaderNames.IfNoneMatch, out var requestETag)
                && entityHash == requestETag)
                return StatusCode(StatusCodes.Status304NotModified);

            return CreateLinksForAuthor(_mapper.Map<AuthorDto>(author));
        }

        [HttpPost(Name = nameof(CreateAuthorAsync))]
        public async Task<ActionResult> CreateAuthorAsync(AuthorForCreationDto authorForCreationDto) {
            var author = _mapper.Map<Author>(authorForCreationDto);
            _repositoryWrapper.Author.Create(author);
            var result = await _repositoryWrapper.Author.SaveAsync();
            if (!result) throw new Exception("创建资源 Author 失败");

            var authorCreated = CreateLinksForAuthor(_mapper.Map<AuthorDto>(author));
            return CreatedAtRoute(nameof(GetAuthorAsync), new {authorId = authorCreated.Id}, authorCreated);
        }

        [HttpDelete("{authorId}", Name = nameof(DeleteAuthorAsync))]
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