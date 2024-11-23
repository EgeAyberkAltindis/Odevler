using MODEL.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Enitity
{
    public class Islemci:BaseEntiy
    {
        public string IslemciModel { get; set; }
        public int CekirdekSayısı { get; set; }

        public List<Bilgisayar> Bilgisayar { get; set; }
    }
}
