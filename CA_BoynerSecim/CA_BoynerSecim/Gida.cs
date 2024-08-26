

namespace CA_BoynerSecim
{
    public class Gida:Urun
    {
        public  DateTime SonKullanmaTarihi { get; set; }
        public  string Tadı { get; set; }

        public override decimal KdvliFiyat(decimal Fiyat)
        {
            return Fiyat;
        }
    }
}
