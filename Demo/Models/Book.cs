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
        public string Name { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public string Status { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime TimePublish { get; set; }
        public string Description { get; set; }
        public ICollection<Author> Authors { get; set; }
        public ICollection<Order> Orders { get; set; }
        / 
        public Category Category { get; set; }
    }
}
