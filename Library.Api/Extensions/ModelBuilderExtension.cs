using System;
using Library.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace Library.Api.Extensions {
    public static class ModelBuilderExtension {
        public static void SeedData(this ModelBuilder modelBuilder) {
            var authorId1 = Guid.NewGuid();
            var authorId2 = Guid.NewGuid();
            
            modelBuilder.Entity<Author>().HasData(
                new Author {
                    Id = authorId1,
                    Name = "Author 1",
                    BirthDate = new DateTimeOffset(new DateTime(1960,11,1)),
                    BirthPlace = "中国香港",
                    Email = "author1@deali.cn"
                },
                new Author {
                    Id = authorId2,
                    Name = "Author 2",
                    BirthDate = new DateTimeOffset(new DateTime(1970,1,20)),
                    BirthPlace = "London, England",
                    Email = "author2@deali.cn"
                }
            );

            modelBuilder.Entity<Book>().HasData(
                new Book {
                    Id = Guid.NewGuid(),
                    Title = "Book 1",
                    Description = "Description of Book 1",
                    Pages = 281,
                    AuthorId = authorId1
                },
                new Book {
                    Id = Guid.NewGuid(),
                    Title = "Book 2",
                    Description = "Description of Book 2",
                    Pages = 382,
                    AuthorId = authorId2
                },
                new Book {
                    Id = Guid.NewGuid(),
                    Title = "Book 3",
                    Description = "Description of Book 3",
                    Pages = 404,
                    AuthorId = authorId1
                },
                new Book {
                    Id = Guid.NewGuid(),
                    Title = "Book 4",
                    Description = "Description of Book 4",
                    Pages = 501,
                    AuthorId = authorId2
                },
                new Book {
                    Id = Guid.NewGuid(),
                    Title = "Book 5",
                    Description = "Description of Book 5",
                    Pages = 320,
                    AuthorId = authorId1
                }
            );
        }
    }
}