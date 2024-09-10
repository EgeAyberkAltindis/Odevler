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
        AccointingData AccointingData =new AccointingData();

        public void AddId(int id)
        {
            for(int i = 0; i <=5; i++)
            {
                if (i==0)
                {
                    AccointingData.accointingData.Add(GetID(id)) ;   
                }
            }
        }

        public Intern GetID(int id)
        {
            return InternData.aday.Find(x => x.ID == id);
        }

        public int ThrowRandomId()
        {
           int randomSayi=rnd.Next(10);
            return randomSayi+1;
        }
    }
}
