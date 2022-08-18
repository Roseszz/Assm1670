using Demo.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Book> Book { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Author> Author { get; set; }

        public DbSet<Order> Order { get; set; }
        public DbSet<Request> Requests { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            SeedBook(builder);
            SeedCategory(builder);
            SeedAuthor(builder);

            SeedUser(builder);
            SeedRole(builder);
            SeedUserRole(builder);
        }


        private void SeedUserRole(ModelBuilder builder)
        {
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    UserId = "1",
                    RoleId = "1"
                },
                new IdentityUserRole<string>
                {
                    UserId = "2",
                    RoleId = "2"
                },
                new IdentityUserRole<string>
                {
                    UserId = "3",
                    RoleId = "3"
                }
            );
        }

        private void SeedRole(ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = "1",
                    Name = "Admin",
                    NormalizedName = "Admin"
                },
                new IdentityRole
                {
                    Id = "2",
                    Name = "Customer",
                    NormalizedName = "Customer"
                },
                new IdentityRole
                {
                    Id = "3",
                    Name = "Staff",
                    NormalizedName = "Staff"
                }
            );
        }

        private void SeedUser(ModelBuilder builder)
        {
            //tạo tài khoản test cho Staff & customer
            var admin = new IdentityUser
            {
                Id = "1",
                Email = "admin@gmail.com",
                UserName = "admin@gmail.com",
                NormalizedUserName = "admin@gmail.com"
            };
            var customer = new IdentityUser
            {
                Id = "2",
                Email = "customer@gmail.com",
                UserName = "customer@gmail.com",
                NormalizedUserName = "customer@gmail.com"
            };
            var Staff = new IdentityUser
            {
                Id = "3",
                Email = "Staff@gmail.com",
                UserName = "Staff@gmail.com",
                NormalizedUserName = "Staff@gmail.com"
            };

            //khai báo thư viện để mã hóa mật khẩu cho user
            var hasher = new PasswordHasher<IdentityUser>();

            //set mật khẩu đã mã hóa cho từng user
            admin.PasswordHash = hasher.HashPassword(admin, "6Z*U^E_y+_}0mgo");
            customer.PasswordHash = hasher.HashPassword(customer, "6Z*U^E_y+_}0mgo");
            Staff.PasswordHash = hasher.HashPassword(Staff, "6Z*U^E_y+_}0mgo");

            //add 2 tài khoản test vào bảng User
            builder.Entity<IdentityUser>().HasData(Staff, customer);
        }

        private void SeedBook(ModelBuilder builder)
        {
            builder.Entity<Book>().HasData(
                new Book { Id = 1, Name = "Hamlet ", Quantity = 10, Price = 100.0, TimePublish = DateTime.Parse("12/09/1996"), AuthorId = 1, CategoryId = 1, Image = "https://edit.org/images/cat/book-covers-big-2019101610.jpg" },
                new Book { Id = 2, Name = "The Great Gatsby", Quantity = 10, Price = 200.0, TimePublish = DateTime.Parse("12/06/2000"), AuthorId = 2, CategoryId = 2, Image = "https://img.freepik.com/free-psd/book-cover-mockup_125540-572.jpg?w=2000" },
                new Book { Id = 3, Name = "One Hundred Years of Solitude", Quantity = 10, Price = 400.0, TimePublish = DateTime.Parse("12/07/2009"), AuthorId = 3, CategoryId = 3, Image = "https://img.freepik.com/free-psd/book-cover-mockup_125540-572.jpg?w=2000" },
                new Book { Id = 4, Name = "Don Quixote", Quantity = 10, Price = 700.0, TimePublish = DateTime.Parse("12/03/2012"), AuthorId = 4, CategoryId = 4, Image = "https://edit.org/images/cat/book-covers-big-2019101610.jpg" },
                new Book { Id = 5, Name = "Moby Dick ", Quantity = 10, Price = 200.0, TimePublish = DateTime.Parse("12/01/2005"), AuthorId = 5, CategoryId = 5, Image = "https://img.freepik.com/free-psd/book-cover-mockup_125540-572.jpg?w=2000" }
                );
        }
        private void SeedCategory(ModelBuilder builder)
        {
            builder.Entity<Category>().HasData(
                new Category { Id = 1, Name = " Novel"},
                new Category { Id = 2, Name = " Fantasy"},
                new Category { Id = 3, Name = " Romance"},
                new Category { Id = 4, Name = " Horror"},
                new Category { Id = 5, Name = " Comedy"}
                );
        }
        private void SeedAuthor(ModelBuilder builder)
        {
            _ = builder.Entity<Author>().HasData(
                new Author { Id = 1, Name = "Long", Email = "Long@gmail.com", Age = 40 },
                new Author { Id = 2, Name = "Minh", Email = "Minh@gmail.com", Age = 70 },
                new Author { Id = 3, Name = "Khanh", Email = "Khanh@gmail.com", Age = 50 },
                new Author { Id = 4, Name = "Ha", Email = "Ha@gmail.com", Age = 30 },
                new Author { Id = 5, Name = "Hanh", Email = "Hanh@gmail.com", Age = 40 }
                );
        }
    }
}
