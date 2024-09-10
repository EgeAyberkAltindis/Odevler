using CA_OCP_ODEV.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_OCP_ODEV.Data
{
    public class InternData
    {
        public static List<Intern> aday  = new List<Intern>()
        {
                new Intern(){ID=1,FirstName="ege",Age=18,Gmail="ayberkege6@gmail.com",LastName="altındiş"},
                new Intern(){ID=2,FirstName="hasan",LastName="altındiş",Age=23,Gmail="hasan@gmail.com"},
                new Intern(){ID=3,FirstName="arzu",LastName="özçivi",Age=23,Gmail="arzu@gmail.com"},
                new Intern(){ID=4,FirstName="mert",LastName="özçivi",Age=25,Gmail="mert@gmail.com"},
                new Intern(){ID=5,FirstName="özgür",LastName="altındiş",Age=27,Gmail="özgür@gmail.com"},
                new Intern(){ID=6,FirstName="onur",LastName="altındiş",Age=68,Gmail="onur@gmail.com"},
                new Intern(){ID=7,FirstName="sude",LastName="uzun",Age=20,Gmail="sude@gmail.com"},
                new Intern(){ID=8,FirstName="emine",LastName="özçivi",Age=56,Gmail="emine@gmail.com"},
                new Intern(){ID=9,FirstName="ceyla",LastName="sığınç",Age=45,Gmail="ceyla@gmail.com"},
                new Intern(){ID=10,FirstName="kadriye",LastName="özçivi",Age=45,Gmail="kadriye@gmail.com"}
        };
    }
}
