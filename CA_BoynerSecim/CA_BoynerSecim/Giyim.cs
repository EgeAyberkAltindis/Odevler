

namespace CA_BoynerSecim
{ 
    public  class Giyim:Urun
    {
        public string beden  { get; set; }
        public string etiket { get; set; }
        
        public override decimal KdvliFiyat(decimal Fiyat)
        {
            Urun yeniÜrün = new Urun();
            DateTime date = DateTime.Now;
            if(date.Month== 10||date.Month== 11)
            {
                yeniÜrün.IndirimliFiyat=Fiyat * 0.90m; 
                return IndirimliFiyat;
            }
            else
            {
                yeniÜrün.IndirimliFiyat = Fiyat * 0.95m;
                return IndirimliFiyat;
            }
         
        }
    }
}
