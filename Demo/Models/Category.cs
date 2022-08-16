using System.ComponentModel.DataAnnotations;

namespace Demo.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public Book Book { get; set; }
    }
}
