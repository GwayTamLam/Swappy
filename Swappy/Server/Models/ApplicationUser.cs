using Microsoft.AspNetCore.Identity;

namespace Swappy.Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? FirstName {  get; set; }
        public string? LastName { get; set;}
    }
}