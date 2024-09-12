
using Bilgisayar_Dal.Factory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilgisayar_Dal.Factory
{
    public class BİlgisayarKullan
    {
        public void Kullan(BilgisayarBuilder bilgisayar)
        {
            bilgisayar.Anakart();
            bilgisayar.EkranKartı();
            bilgisayar.Islemci();
            bilgisayar.Marka();
            bilgisayar.Model();
            bilgisayar.Ram();
       
        }
    }
}
