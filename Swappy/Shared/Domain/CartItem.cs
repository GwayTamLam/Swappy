using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swappy.Shared.Domain
{
    public class CartItem : BaseDomainModel
    {
        public virtual Product? Product { get; set; }
        public int ProductId { get; set; }
        public int ProductQuantity { get; set; }
        public virtual Cart? Cart { get; set; }
        public int CartId { get; set; }

    }
}
