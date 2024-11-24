using Microsoft.AspNetCore.Identity;
using MODEL.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Enitity
{
    public class User :IdentityUser<int>
    {
        public string  Adress { get; set; }

        //1 ekrankartı n bilgisayar --- 1 bilgisayarın 1 tane 
        // 1 order -> 1 user // 1 user -> n order
        public List<Order> Order { get; set; }
    }
}
