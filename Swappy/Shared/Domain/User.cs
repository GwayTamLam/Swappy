using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swappy.Shared.Domain
{
    public class User : BaseDomainModel
    {
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? UserName { get; set; }
        [Required]
        [EmailAddress]
        public string? Email { get; set; }
        [Required]
        [RegularExpression(@"^\d{8}$", ErrorMessage = "Phone number must be 8 numeric characters")]
        public string? PhoneNumber { get; set; }
        public string? Bio { get; set;}
        public byte[]? ProfilePicture { get; set;}

        public virtual ICollection<Product>? Products { get; set;}
        public virtual ICollection<CartItem>? CartItems { get; set; }
    }
}
