using System.Collections;
using System.Net.Http.Headers;


namespace CA_Dr_Secim
{
    public class Site
    {
        public static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();

            //ürün ekleme

            Bilgisayar pc1 = new Bilgisayar();
            pc1.Isim = "asus";
            pc1.EkranKartı = "nvidia";
            pc1.Ram = "32 GB";
            pc1.DepolamaAlanı = "512 GB";
            arrayList.Add(pc1);

            Bilgisayar pc2 = new Bilgisayar();
            pc2.Isim = "msi";
            pc2.EkranKartı = "Quantro5000";
            pc2.Ram = "32 GB";
            pc2.DepolamaAlanı = "1 TB";
            arrayList.Add(pc2);

            Bilgisayar pc3 = new Bilgisayar();
            pc2.Isim = "dell";
            pc3.Ram = "64 GB";
            pc3.EkranKartı = "ryzen";
            pc3.DepolamaAlanı = "2 TB";
            arrayList.Add(pc3);

            Telefon tel1 = new Telefon();
            tel1.Isim = "iphone";
            tel1.Marka = "iphone15";
            tel1.DepolamaAlanı = "128 GB";
            arrayList.Add(tel1);

            Telefon tel2 = new Telefon();
            tel2.Isim = "samsung";
            tel2.Marka = "A20";
            tel2.DepolamaAlanı = "256 GB";
            arrayList.Add(tel2);

            Kitap kitap1 = new Kitap();
            kitap1.Isim = "Şeker Portakalı";
            kitap1.Yazar = "Jose Mauro De Vasconcelos";
            kitap1.YayınEvi = "Can yayınları";
            arrayList.Add(kitap1);

            Kitap kitap2 = new Kitap();
            kitap2.Isim = "Kürk Mantolu Madonna";
            kitap2.Yazar = "Sabahattin Ali";
            kitap2.YayınEvi = "yapı kredi pyunları";
            arrayList.Add(kitap2);

            Kitap kitap3 = new Kitap();
            kitap3.Isim = "İnsan Neyle Yaşar?";
            kitap3.YayınEvi = "İndigo Kitap";
            kitap3.Yazar = " Lev Nikolayeviç Tolstoy";


            Puzzle puzzle1 = new Puzzle();
            puzzle1.Isim = "Atatürk Portre";
            puzzle1.ParcaSayısı = 1000;
            puzzle1.OyuncakKullanıcıCinsi = "unisex";
            arrayList.Add(puzzle1);

            Puzzle puzzle2 = new Puzzle();
            puzzle2.Isim = "boğaz köprüsü";
            puzzle2.ParcaSayısı = 2000;
            puzzle2.OyuncakKullanıcıCinsi = "unisex";
            arrayList.Add(puzzle2);

            Figür fig1 = new Figür();
            fig1.Isim = "baby yoda";
            fig1.OyuncakKullanıcıCinsi = "erkek";
            arrayList.Add(fig1);

            Figür fig2 = new Figür();
            fig2.Isim = "Barbie";
            fig2.OyuncakKullanıcıCinsi = "kız";
            arrayList.Add(fig2);

            //işlem secme
            Console.WriteLine("Bilge Markete Hoşgeldiniz\naşağıdan işlem seçiniz");
            Console.WriteLine("1-Kitap\r\n2-Elektronik\r\n3-Oyuncak");
            string secim = Console.ReadLine();
            switch (secim)
            {
                case "1":
                    Console.WriteLine("1-Edebiyat\n2-Hikaye\n3-felsefe\n");
                    Console.WriteLine("seçmek istediğiniz kitap cinisini yazınız");
                    string kitapSecim = Console.ReadLine();
                    switch (kitapSecim)
                    {
                        case "1":
                            foreach (object urun in arrayList)
                            {
                                if (urun is Kitap)
                                {
                                    Kitap kitapp = (Kitap)urun;
                                    Console.WriteLine(kitapp.Isim);
                                    break;
                                }
                                break;
                            }
                            break;
                        case "2":
                            foreach (object urun in arrayList)
                            {
                                if (urun is Kitap)
                                {
                                    Kitap anan = (Kitap)urun;
                                    Console.WriteLine(kitap2.Isim);
                                    break;
                                }

                            }
                            break;
                        case "3":
                            foreach (object urun in arrayList)
                            {
                                if (urun is Kitap)
                                {
                                    Kitap baban = (Kitap)urun;
                                    Console.WriteLine(kitap3.Isim + kitap3.YayınEvi);
                                    break;
                                }

                            }
                            break;
                    }
                    break;
                case "2":

                    break;
                case "3":

                    break;
            }

        }
    }
}