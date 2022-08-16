using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Demo.Models
{
    public class Author
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public DateTime Age { get; set; }
        public Book Book  { get; set; }
    }
}
