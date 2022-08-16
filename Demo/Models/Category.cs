using System.ComponentModel.DataAnnotations;

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

        // category-book one to one
        [Required]
        [Display(Name = "Category Name")]
        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}
