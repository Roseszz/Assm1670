﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Demo.Models
{
    public class Author
    {
        public int Id { get; set; }
       
        [Required]
        [MinLength(3, ErrorMessage = "Author  name must be at least 3 characters")]
        [MaxLength(30)]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        [Display(Name = "Author Name")]
        public int BookId { get; set; }

        //Author  - Book : 1 to Many
        public Book Book  { get; set; }
    }
}
