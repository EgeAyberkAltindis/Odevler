using CA_OCP_ODEV.Data;
using CA_OCP_ODEV.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_OCP_ODEV.Abstract
{
    public class Intern : Employee, IIntern
    {
        Random rnd = new Random();  
        InternData kisiler = new InternData();

        public Intern GetID()
        {
            throw new NotImplementedException();
        }

        public int ThrowRandomId()
        {
           int randomSayi=rnd.Next(11);
            return randomSayi;
        }
    }
}
