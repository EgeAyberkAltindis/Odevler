using Microsoft.EntityFrameworkCore.Storage;
using MODEL.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Enitity
{
    public class Ekran:BaseEntiy
    {
        public short  widht { get; set; }
        public short height { get; set; }
        public List<Bilgisayar> Bilgisayar{ get; set; }
    }
}
