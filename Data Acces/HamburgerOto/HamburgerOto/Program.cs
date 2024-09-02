
//Scaffold-DbContext "server=DESKTOP-ABTB3OG\SQLEXPRESS;database=HamburgerOtomasyon;Trusted_Connection=True;TrustServerCertificate=True" Microsoft.EntityFrameworkCore.SqlServer -o Models



using HamburgerOto.Models;
using Microsoft.EntityFrameworkCore.Update.Internal;

namespace HamburgerOto
{
    class Program
    {
        public static void Main(string[] args)
        {
            HamburgerOtomasyonContext hb = new HamburgerOtomasyonContext();
            var drinkID = hb.Drinks.Where(x => x.DrinkName == "cola").FirstOrDefault().Id;

            Drink drink = new Drink();
            drink.DrinkName = "cola";
            drink.Id = drinkID;
            drink.Sweetie = false;
            drink.Litter = 1;

            hb.Drinks.Add(drink);
            if (hb.SaveChanges() > 0)
            {
                Console.WriteLine("Kayıt başarılı");
            }
            else
            {

                Console.WriteLine("Bir hata meydana geldi!");
            }

        }    
    }
}
