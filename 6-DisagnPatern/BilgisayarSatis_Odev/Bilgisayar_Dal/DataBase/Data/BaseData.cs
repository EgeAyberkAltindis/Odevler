using Bilgisayar_Dal.DataBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilgisayar_Dal.DataBase.Data
{
    public class BaseData
    {
        public static List<Anakart> GetMovies()
        {

            return new List<Anakart>
            {

                new Anakart {ID=1,Fiyat=15000,IslemciTipi="Inteli7"},
                new Anakart {ID=2,Fiyat=14000,IslemciTipi="Inteli5"},
                new Anakart {ID=3,Fiyat=17000,IslemciTipi="Inteli9"},
            };
        }
        public static List<EkranKartı> GetEkranKartı()
        {
            return new List<EkranKartı>
           {
                new EkranKartı {ID=1,Bellek=8,Uretici="Nvidida",Fiyat=50000},
                new EkranKartı{ID=2,Bellek=9,Uretici="Amd",Fiyat=40000 }
           };
        }
        public static List<Islemci> GetIslemci()
        {
            return new List<Islemci>
            {
                new Islemci(){ID=1,Fiyat=16000,ÇekirdekSayı=2,Seri="amd ryzen 7.nesil"},
                new Islemci(){ID=1,Fiyat=20000,ÇekirdekSayı=3,Seri="intel i9 "},
                new Islemci(){ID=2,Fiyat=30000,ÇekirdekSayı=8,Seri="İntel i9"}
            };
        }
        public static List<Model> GetModels()
        {
            return new List<Model>()
            {
                new Model {ID=1,LaptopMu=false },
                new Model{ID= 2,LaptopMu = false },
                new Model{ID=3 ,LaptopMu=true}
            };
        }
        public static List<Ram> GetRams()
        {
            return new List<Ram>()
            {
                new Ram(){ID=1,Fiyat=5000,Hız=5880,Kapasite=16 },
                new Ram {ID=2,Fiyat=10000,Hız =8000,Kapasite=64 },
                new Ram {ID=3,Fiyat=15000,Hız=10000,Kapasite=256}
            };
        }
    }
}
