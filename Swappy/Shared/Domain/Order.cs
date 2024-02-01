using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swappy.Shared.Domain
{
    public class Order : BaseDomainModel
    {
        public virtual User? User { get; set; }
        public int UserID { get; set; }
        
        public decimal TotalAmount { get; set; }

    }
}
