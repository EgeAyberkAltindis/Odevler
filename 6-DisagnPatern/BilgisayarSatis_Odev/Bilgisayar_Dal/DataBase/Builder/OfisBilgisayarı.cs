using Azure.Core;
using Bilgisayar_Dal.DataBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilgisayar_Dal.DataBase.Builder
{
    public class OfisBilgisayarı : BilgisayarBuilder
    {
        public OfisBilgisayarı()
        {
            _bilgisayar= new Bilgisayar();
        }

        public override void Anakart()
        {
            throw new NotImplementedException();
        }

        public override void EkranKartı()
        {
            throw new NotImplementedException();
        }

        public override void Islemci()
        {
            throw new NotImplementedException();
        }

        public override void Model()
        {
            throw new NotImplementedException();
        }

        public override void Ram()
        {
            throw new NotImplementedException();
        }
    }
}
