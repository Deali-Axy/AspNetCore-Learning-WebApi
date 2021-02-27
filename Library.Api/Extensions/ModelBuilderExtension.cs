using System;
using System.Collections.Generic;
using System.Linq;
using Library.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace Library.Api.Extensions {
    public static class ModelBuilderExtension {
        public static void SeedData(this ModelBuilder modelBuilder) {
            var rnd = new Random();
            var birthPlaces = new List<string> {"HongKong", "London", "Beijing", "Shanghai", "NewYork", "ToKyo"};

            var authors = new List<Author>();

            for (var i = 1; i <= 50; i++) {
                authors.Add(new Author {
                    Id = Guid.NewGuid(),
                    Name = $"Author {i}",
                    BirthDate = new DateTimeOffset(new DateTime(rnd.Next(1950, 2010), rnd.Next(1, 13), rnd.Next(1, 29))),
                    BirthPlace = birthPlaces.OrderBy(_ => Guid.NewGuid()).First(),
                    Email = $"author{i}@deali.cn"
                });
            }

            modelBuilder.Entity<Author>().HasData(authors);

            var books = new List<Book>();

            for (var i = 1; i <= 200; i++) {
                books.Add(new Book {
                    Id = Guid.NewGuid(),
                    Title = $"Book {i}",
                    Description = $"Description of Book {i}",
                    Pages = rnd.Next(99, 1001),
                    AuthorId = authors.OrderBy(_ => Guid.NewGuid()).First().Id
                });
            }

            modelBuilder.Entity<Book>().HasData(books);
        }
    }
}