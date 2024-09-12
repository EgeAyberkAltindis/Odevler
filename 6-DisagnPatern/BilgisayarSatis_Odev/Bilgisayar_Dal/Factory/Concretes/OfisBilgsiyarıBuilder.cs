using Bilgisayar_Dal.Factory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilgisayar_Dal.Factory.Concretes
{
    public class OfisBilgsiyarıBuilder:BilgisayarBuilder
    {
        public OfisBilgsiyarıBuilder()
        {
          _bilgisayar=new Entities.Bilgisayar();
        }
        public override void Anakart()
        {
            _bilgisayar.AnaKart = "";
        }
        public override void EkranKartı()
        {
            _bilgisayar.EkranKartı = "";
        }
        public override void Islemci()
        {
            _bilgisayar.Islcemci = "";
        }
        public override void Marka()
        {
            _bilgisayar.Marka = "";
        }
        public override void Model()
        {
            _bilgisayar.Model = "";
        }
        public override void Ram()
        {
            _bilgisayar.Ram = "";
        }
    }
}
