using Microsoft.EntityFrameworkCore.Update.Internal;
using MODEL.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Enitity
{
    public class Bilgisayar : BaseEntiy
    {

        public string ComputerName { get; set; }
        public decimal  UnitPrice  { get; set; }
        public short UnitInStock { get; set; }
        public string Description{ get; set; }
        public string ImageURL {  get; set; }



        //Mapping
        public int CategoryId { get; set; }
        public BilgisayarCategory Category { get; set; }
        public List<OrderDetail> OrderDetail { get; set; }

        public int EkranKartıId { get; set; }
        public EkranKartı EkranKartı { get; set; }

        public int IslemciId { get; set; }
        public Islemci Islemci { get; set; }

        public int EkranId { get; set; }
        public Ekran Ekran { get; set; }

        public int RamId { get; set; }
        public Ram Ram { get; set; }
    }
}
