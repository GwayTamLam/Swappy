using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swappy.Shared.Domain
{
    public class User : BaseDomainModel
    {
        public string? Name { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Bio { get; set;}

        public virtual ICollection<Product>? Products { get; set;}
        public virtual ICollection<CartItem>? CartItems { get; set; }
    }
}
