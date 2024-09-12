using Bilgisayar_Dal.Factory.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilgisayar_Dal.Factory.Abstract
{
    public abstract class BilgisayarBuilder
    {
        //marka,
        //model,
        //ram,
        //ekrankartı,
        //anakart,
        //işlemci

        protected Bilgisayar _bilgisayar;
        public Bilgisayar Bilgisayar { get { return _bilgisayar; } }

        public abstract void Marka();
        public abstract void Model();
        public abstract void Ram();
        public abstract void EkranKartı();
        public abstract void Anakart();
        public abstract void Islemci();

    }
}
