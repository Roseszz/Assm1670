using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Demo.Models
{
    public class Book
    {
         public int Id { get; set; }

        [Required]
        [MinLength(5, ErrorMessage = "Book  name must be at least 5 characters")]
        [MaxLength(30)]
        public string Name { get; set; }

        [Required]
        [Range(1, 100)]
        public int Quantity { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime TimePublish { get; set; }

        public string Description { get; set; }

        //Book  - author: many to one
        //public ICollection<Author> Authors { get; set; }

        //Book  - Order: 1 to Many
        public ICollection<Order> Orders { get; set; }

        //Book  - Category: 1 to many
        

        public int CategoryId { get; set; }

        //thuộc tính liên kết (dùng truy xuất trong code)
        public Category Category { get; set; }


        public Author Author { get; set; }

        [Required]
        [Display(Name = "Author name")]
        public int AuthorId { get; set; }


    }
}
