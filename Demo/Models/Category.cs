using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Demo.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [MinLength(1 , ErrorMessage ="Category must ave atleast 5 chaaracter")]
        [MaxLength(20)]
        public string Name { get; set; }

        public string Description { get; set; }

        // category-book many to one

        public Book Book { get; set; }


    }
}
