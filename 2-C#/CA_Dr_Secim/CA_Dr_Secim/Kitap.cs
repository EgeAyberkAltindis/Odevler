using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Dr_Secim
{
    internal class Kitap:Urun
    {
        public string Cins { get; set; }
        public string Yazar { get; set; }
        public string YayınEvi { get; set; }
    }
}
