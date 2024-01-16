using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swappy.Shared.Domain
{
    public class Cart : BaseDomainModel
    {
        public virtual Product? Product { get; set; }
        public int ProductID { get; set; }
        public virtual User? User { get; set; }
        public int UserID { get; set; }
        public int ProductQuantity { get; set; }
        public double TotalPrice { get; set; }
    }
}
