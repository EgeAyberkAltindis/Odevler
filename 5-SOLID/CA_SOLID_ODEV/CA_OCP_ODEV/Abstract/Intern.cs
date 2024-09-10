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
        Intern IIntern.GetIntern()
        {
            while(true) 
            {
                Random random = new Random();
                int sayı = random.Next(11);

                Intern intern = new Intern();
                intern.ID = sayı;

                if (sayı == intern.ID)
                {
                    return intern;
                }
                
            }
        }
    }
}
