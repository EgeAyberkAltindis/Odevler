using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace MMOARPG_DLL.Entities
{
   public class Player
    {
        public int GradeID { get; set; }
        public int ClothesID { get; set; }
        public int RaceID { get; set; }
        public int WeaponID { get; set; }
        public Grade Grade { get; set; }
        public Clothes Clothes { get; set; }
        public Race Race { get; set; }
        public Weapon Weapon { get; set; }

    }
}
