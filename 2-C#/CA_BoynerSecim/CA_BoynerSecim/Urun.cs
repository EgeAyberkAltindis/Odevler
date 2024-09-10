

namespace CA_BoynerSecim
{
    public class Urun
    {
        public  decimal  IndirimliFiyat { get; set; }
        public decimal KdvsizFiyat { get; set; }
        public decimal Fiyat {  get; set; }
        
        public virtual decimal KdvliFiyat(decimal Fiyat)
        {
           return Fiyat*1.20m;
        }
        public  string  Marka { get; set; }
    }
}
