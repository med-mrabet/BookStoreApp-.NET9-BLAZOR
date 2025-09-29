using BookStoreApp.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookStoreApp.Data.Context
{
    public class BookStoreContext : IdentityDbContext<ApiUser>
    {
        public BookStoreContext(DbContextOptions<BookStoreContext> options) : base(options)
        {
        }
        // Define DbSets for your entities here
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Author>().HasKey(a => a.Id);
            modelBuilder.Entity<Book>(entity =>
            {
                entity.HasOne(b => b.Author)
                      .WithMany()
                      .HasForeignKey(b => b.AuthorId);
                entity.HasKey(b => b.Id);
                entity.Property(b => b.ISBN).HasMaxLength(50);
            });

            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = "1",
                    Name = "User",
                    NormalizedName = "USER"

                },
                new IdentityRole
                {
                    Id = "2",
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                }
            );

            modelBuilder.Entity<ApiUser>().HasData(
               new ApiUser
               {
                   Id = "3",
                   Email = "user@mail.com",
                   FirstName="user ",
                   LastName = "system",
                   PasswordHash = new PasswordHasher<ApiUser>().HashPassword(null,"p@ssword")

               },
               new ApiUser
               {
                   Id = "4",
                   Email = "admin@mail.com",
                   FirstName = "admin ",
                   LastName = "system",
                   PasswordHash = new PasswordHasher<ApiUser>().HashPassword(null, "p@ssword")
               }
               );

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "1",
                    UserId = "3"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "2",
                    UserId = "4"
                }
                );
            // Configure entity relationships and constraints here if needed
        }
    }
}
