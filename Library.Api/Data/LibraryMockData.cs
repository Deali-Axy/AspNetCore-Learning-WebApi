using System;
using System.Collections.Generic;
using Library.Api.Models;

namespace Library.Api.Data {
    public class LibraryMockData {
        /// 获取 LibraryMockData 实例
        public static LibraryMockData Current { get; } = new LibraryMockData();

        public List<AuthorDto> Authors { get; set; }
        public List<BookDto> Books { get; set; }

        public LibraryMockData() {
            var authorId1 = Guid.NewGuid();
            var authorId2 = Guid.NewGuid();

            Authors = new List<AuthorDto> {
                new AuthorDto {
                    Id = authorId1,
                    Name = "Author 1",
                    Age = 46,
                    Email = "author1@deali.cn"
                },
                new AuthorDto {
                    Id = authorId2,
                    Name = "Author 2",
                    Age = 38,
                    Email = "author2@deali.cn"
                }
            };

            Books = new List<BookDto> {
                new BookDto {
                    Id = Guid.NewGuid(),
                    Title = "Book 1",
                    Description = "Description of Book 1",
                    Pages = 281,
                    AuthorId = authorId1
                },
                new BookDto {
                    Id = Guid.NewGuid(),
                    Title = "Book 2",
                    Description = "Description of Book 2",
                    Pages = 382,
                    AuthorId = authorId2
                },
                new BookDto {
                    Id = Guid.NewGuid(),
                    Title = "Book 3",
                    Description = "Description of Book 3",
                    Pages = 404,
                    AuthorId = authorId1
                },
                new BookDto {
                    Id = Guid.NewGuid(),
                    Title = "Book 4",
                    Description = "Description of Book 4",
                    Pages = 501,
                    AuthorId = authorId2
                },
                new BookDto {
                    Id = Guid.NewGuid(),
                    Title = "Book 5",
                    Description = "Description of Book 5",
                    Pages = 320,
                    AuthorId = authorId1
                }
            };
        }
    }
}