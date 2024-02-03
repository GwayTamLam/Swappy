using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swappy.Shared.Domain
{
    public class Product : BaseDomainModel
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string? ProductDimension { get; set; }
        public string? ProductPicture { get; set; }
        public virtual User? User { get; set; }
        [Required]

        public int UserID { get; set; }
        public virtual Category? Category { get; set; }
        [Required]

        public int CategoryID { get; set; }
        public virtual ICollection<CartItem>? CartItems { get; set; }
    }
}
