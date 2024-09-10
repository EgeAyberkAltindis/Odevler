

namespace CA_BoynerSecim
{
   public class Kozmetik:Urun
    {
        public  string Bölüm { get; set; }

        public override decimal KdvliFiyat(decimal Fiyat)
        {
            Urun yeniÜrün = new Urun();
            yeniÜrün.IndirimliFiyat = Fiyat * 0.95m;
            return IndirimliFiyat;
        }
    }
}
