using Demo.Models;
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
        public DbSet<Book> Order { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            SeedBook(builder);
            SeedCategory(builder);
            SeedAuthor(builder);
             

        }

        private void SeedAuthor(ModelBuilder builder)
        {
            builder.Entity<Author>().HasData(
                new Author { Id=1,Name="Long",Email="Long@gmail.com" ,Age=40},
                new Author { Id = 2, Name = "Minh", Email = "Minh@gmail.com", Age = 70 },
                new Author { Id = 3, Name = "Khanh", Email = "Khanh@gmail.com", Age = 50 },
                new Author { Id = 4, Name = "Ha", Email = "Ha@gmail.com", Age = 30 },
                new Author { Id = 5, Name = "Hanh", Email = "Hanh@gmail.com", Age = 40 }
                );
        }


        private void SeedCategory(ModelBuilder builder)
        {
            builder.Entity<Category>().HasData(
                new Category { Id =1 , Name=" Novel", Description=" Novel Type"},
                new Category { Id = 2, Name = " Fantasy", Description = " Fantasy Type" },
                new Category { Id = 3, Name = " Romance", Description = " Romance Type" },
                new Category { Id = 4, Name = " Horror", Description = " Horror Type" },
                new Category { Id = 5, Name = " Comedy", Description = " Comedy Type" }
                );
        }

        private void SeedBook(ModelBuilder builder)
        {
            builder.Entity<Book>().HasData(
                new Book { Id=1,Name= "Hamlet ", Quantity=10, Price=100.0,TimePublish= DateTime.Parse("12/09/1996"), Description="None"},
                new Book { Id = 2, Name = "The Great Gatsby", Quantity = 10, Price = 200.0, TimePublish = DateTime.Parse("12/06/2000"),Description = "None" },
                new Book { Id = 3, Name = "One Hundred Years of Solitude", Quantity = 10, Price = 400.0, TimePublish = DateTime.Parse("12/07/2009"), Description = "None" },
                new Book { Id = 4, Name = "Don Quixote", Quantity = 10, Price = 700.0, TimePublish = DateTime.Parse("12/03/2012"),  Description = "None" },
                new Book { Id = 5, Name = "Moby Dick ", Quantity = 10, Price = 200.0, TimePublish = DateTime.Parse("12/01/2005"),  Description = "None" }
                );
        }
    }
}
