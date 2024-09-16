using Bilgisayar_Dal.DataBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilgisayar_Dal.DataBase.Builder
{
    public abstract class BilgisayarBuilder
    {
        protected  Bilgisayar _bilgisayar;
        public Bilgisayar Bilgisayar {  get { return _bilgisayar; } }

        public abstract void Anakart();
        public abstract void EkranKartı();
        public abstract void Ram();
        public abstract void Islemci();
        public abstract void Model();
                           



    }
}
