using MODEL.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Enitity
{
    public class Order:BaseEntiy
    {
        public string ShippedAddress { get; set; }
        public DateTime? ShippedDate { get; set; }//null

        public List<OrderDetail> OrderDetail { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
