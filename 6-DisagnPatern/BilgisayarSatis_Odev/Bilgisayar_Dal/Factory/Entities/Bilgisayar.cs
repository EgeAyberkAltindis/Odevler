using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilgisayar_Dal.Factory.Entities
{
    public class Bilgisayar
    {
        //marka,
        //model,
        //ram,
        //ekrankartı,
        //anakart,
        //işlemci
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Ram { get; set; }
        public string EkranKartı { get; set; }
        public string AnaKart { get; set; }
        public string Islcemci { get; set; }

        public override string ToString()
        {
            return $"Marka: {Marka} Model: {Model} Ram: {Ram} EkranKartı: {EkranKartı} Anakart: {AnaKart} Islemci: {Islcemci}";
        }

    }
}
