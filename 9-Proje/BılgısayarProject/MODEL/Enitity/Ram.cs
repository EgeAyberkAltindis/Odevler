using MODEL.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Enitity
{
    public class Ram:BaseEntiy
    {
        public int Kapasite { get; set; }

        public List<Bilgisayar> Bilgisayar { get; set; }
    }
}
