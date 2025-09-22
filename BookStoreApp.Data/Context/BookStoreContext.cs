using BookStoreApp.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStoreApp.Data.Context
{
    public class BookStoreContext : DbContext
    {
        public BookStoreContext(DbContextOptions<BookStoreContext> options) : base(options)
        {
        }
        // Define DbSets for your entities here
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasKey(a => a.Id);
            modelBuilder.Entity<Book>(entity =>
            {
                entity.HasOne(b => b.Author)
                      .WithMany()
                      .HasForeignKey(b => b.AuthorId);
                entity.HasKey(b => b.Id);
                entity.Property(b => b.ISBN).HasMaxLength(50);
            });
            base.OnModelCreating(modelBuilder);
            // Configure entity relationships and constraints here if needed
        }
    }
}
