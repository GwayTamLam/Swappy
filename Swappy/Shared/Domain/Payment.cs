using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swappy.Shared.Domain
{
    public class Payment : BaseDomainModel
    {
        public virtual Order? Order { get; set; }
        public int OrderID { get; set; }
        public virtual User? User { get; set; }
        public int UserID { get; set; }
        public double TotalPrice { get; set; }
        public string? PaymentMethod { get; set; }
    }
}
