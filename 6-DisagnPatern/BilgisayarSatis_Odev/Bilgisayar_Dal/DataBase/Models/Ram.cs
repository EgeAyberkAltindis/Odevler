﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilgisayar_Dal.DataBase.Models
{
    public class Ram:BaseClass
    {
        public List<Bilgisayar> Bilgisayars { get; set; }
        public int Hız { get; set; }
        public int Kapasite { get; set; }
    }
}
