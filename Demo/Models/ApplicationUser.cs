using Microsoft.AspNetCore.Identity;

namespace Demo.Models
{
    public class ApplicationUser
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IdentityUser IdentityUser { get; set; }
        public int UserId { get; set; }
    }
}
