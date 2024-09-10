

namespace CA_BoynerSecim
{
    public class Elektronik:Urun
    {
        public string Cihaz { get; set; }
        public override decimal KdvliFiyat(decimal Fiyat)
        {
            Urun yeniÜrün=new Urun();
            yeniÜrün.IndirimliFiyat= Fiyat*0.90m;
            return IndirimliFiyat ;
        }
    }
}
