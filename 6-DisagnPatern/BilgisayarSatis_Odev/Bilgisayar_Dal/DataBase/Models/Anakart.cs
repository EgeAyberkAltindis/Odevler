using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization.Metadata;
using System.Threading.Tasks;

namespace Bilgisayar_Dal.DataBase.Models
{
    public class Anakart : BaseClass
    {
        public List<Bilgisayar> Bilgisayars { get; set; }
        public string IslemciTipi { get; set; }
    }    
}
