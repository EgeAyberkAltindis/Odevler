using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilgisayar_Dal.DataBase.Models
{
    public class Bilgisayar:BaseClass
    {
        
  
        public int AnakartId { get; set; }
        public int EkranKartıId { get; set; }
        public int IslemciId { get; set; }
        public int MarkaId { get; set; }
        public int ModelId { get; set; }
        public int RamId { get; set; }

        public Anakart Anakart { get; set; }
        public EkranKartı EkranKartı { get; set; }
        public Islemci Islemci { get; set; }
        public Marka Marka { get; set; }
        public Model Model { get; set; }
        public Ram Ram { get; set; }
    }
}
