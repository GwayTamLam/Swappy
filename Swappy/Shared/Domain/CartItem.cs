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
        public int ProductID { get; set; }
        public virtual User? User { get; set; }
        public int UserId { get; set; }
        public virtual Order? Order { get; set; }
        public int? OrderID { get; set; }
        public int? Quantity { get; set; }


    }
}
 