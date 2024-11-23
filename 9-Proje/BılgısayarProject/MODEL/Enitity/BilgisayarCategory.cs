using MODEL.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Enitity
{
    public class BilgisayarCategory:BaseEntiy
    {

        public string CategoryName { get; set; }
        public string Description { get; set; }

        public List<Bilgisayar> Product { get; set; }
    }

}
