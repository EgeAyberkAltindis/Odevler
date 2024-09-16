using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilgisayar_Dal.DataBase.Models
{
    public class Islemci:BaseClass
    {
        public List<Bilgisayar> Bilgisayars { get; set; }
        public string Marka { get; set; }
        public int ÇekirdekSayı { get; set; }
        public  string  Seri { get; set; }
    }
}
