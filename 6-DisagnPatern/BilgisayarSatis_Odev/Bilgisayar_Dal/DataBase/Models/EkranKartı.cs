﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilgisayar_Dal.DataBase.Models
{
    public class EkranKartı:BaseClass
    {
        public List<Bilgisayar> Bilgisayars { get; set; }
        public string Uretici { get; set; }
        public int Bellek { get; set; }
        
    }
}
