using Library.Api.Extensions;
using Microsoft.EntityFrameworkCore;

namespace Library.Api.Entities {
    public class LibraryDbContext : DbContext {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

        public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options) {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);
            // 添加种子数据
            modelBuilder.SeedData();
        }
    }
}