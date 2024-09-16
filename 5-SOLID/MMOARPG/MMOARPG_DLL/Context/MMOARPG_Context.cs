using Microsoft.EntityFrameworkCore;
using MMOARPG_DLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMOARPG_DLL.Context
{
    public class MMOARPG_Context:DbContext
    {
        DbSet<Clothes> Clothess {  get; set; }
        DbSet<Grade> Grades { get; set; }
        DbSet<Player> Players { get; set; }
        DbSet<Weapon> Weapons { get; set; }
        DbSet<Race> Races { get; set; }


    }
}
