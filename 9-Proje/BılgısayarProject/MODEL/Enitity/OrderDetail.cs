using MODEL.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Enitity
{
    public class OrderDetail : BaseEntiy
    {
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }

        public int BilgisayarId { get; set; }
        public Bilgisayar Bilgisayar { get; set; }
    }
}
