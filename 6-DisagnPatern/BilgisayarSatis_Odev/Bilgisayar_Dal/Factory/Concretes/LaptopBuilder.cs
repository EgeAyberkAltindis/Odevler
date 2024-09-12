
using Bilgisayar_Dal.Factory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilgisayar_Dal.Factory.Concretes
{
    public class LaptopBuilder:BilgisayarBuilder
    {
        public LaptopBuilder() 
        { 
            _bilgisayar = new Entities.Bilgisayar();
        }
        public override void Anakart()
        {
            _bilgisayar.AnaKart = "a";
        }

        public override void EkranKartı()
        {
            _bilgisayar.EkranKartı = "b";
        }

        public override void Islemci()
        {
            _bilgisayar.Islcemci = "c";
        }

        public override void Marka()
        {
            _bilgisayar.Marka = "d";
        }

        public override void Model()
        {
            _bilgisayar.Model = "e";
        }

        public override void Ram()
        {
            _bilgisayar.Ram = "d";
        }
    }
}
