/*
 * McBilge Hamburger Otomasyonu
Menüler:
1 - Whooper 150 TL
2-BigMc 130 TL
3-BilgeBurger 200TL
menü seç: 2
Adet: 2
Ekstralar:
1 - Mayonez - ücretsiz
2 - Ketçap - ücretsiz
3 - BBQ - 10 TL
ekstra seçim: 3

Siparişe devam etmek istiyor musun? (e/h):
seçim: h
Adınız: Fatih
Soyadınız: Günalp
Adres: Kadıköy
********************************************
Siparişiniz oluşturuldu. Ödemeniz gereken toplam beden 270 TL
*/
//Console.WriteLine("MENÜLER");
//Console.WriteLine("1 - Whooper 150 tl");
//Console.WriteLine("2-BigMc 130 TL") ;
//Console.WriteLine("3-Bilgeburger 200 tl ");
//Console.WriteLine("hangi menüden yemek istersiniz o menünün numrasını girin ");

//
//

string[] menüler = { "0-Whooper 150 tl", "1-BigMc 130 TL", "2-Bilgeburger 200 tl " };

string[] ekstralar = { "0-Mayonez", "1-Ketçap", "2-BBQ-10 tl" };
int toplambakiye = 0;
do
{
    Console.WriteLine(" McBilge Hamburger Otomasyonu");
    Console.WriteLine("MENÜLER");
    try
    {
        foreach (string m in menüler)
        {
            Console.WriteLine(m);
        }
        Console.WriteLine("lütfen yemek istediğiniz menüyü seçin");
        int menüSecim = int.Parse(Console.ReadLine());
        if (menüSecim == 0 || menüSecim == 1 || menüSecim == 2)
        {
            Console.WriteLine("seçtiğiniz menü: " + menüler[menüSecim+1]);
        }
        else
        {
            Console.WriteLine("********************");
            Console.WriteLine("hatalı veri girdiniz");
            Console.WriteLine("********************");
            Console.WriteLine("menü seçimine gönderiliyorusunuz");
            Console.ReadLine();
            Console.Clear();
            continue;
        }

        Console.WriteLine("kaç adet menü istersiniz");
        int menüAdet = int.Parse(Console.ReadLine());

        foreach (string k in ekstralar)
        {
            Console.WriteLine(k);
        }
        Console.WriteLine("ekstra bir sos seçin");
        int sosSecim = int.Parse(Console.ReadLine());

        if (sosSecim == 0 || sosSecim == 1 || sosSecim == 2)
        {
            Console.WriteLine("seçtiğiniz sos: " + ekstralar[sosSecim+1]);
        }
        else
        {
            Console.WriteLine("********************");
            Console.WriteLine("hatalı veri girdiniz");
            Console.WriteLine("********************");
            Console.WriteLine("menü seçimine gönderiliyorusunuz");
            Console.ReadLine();
            Console.Clear();
            continue;
        }

        Console.WriteLine("Siparişe devam etmek istiyor musun? (e/h):");
        string tusSecim = Console.ReadLine();
        if (tusSecim == "h")
        {
            Console.Clear();
            continue;

        }
        else if (tusSecim == "e")
        {
            Console.WriteLine("adınız: ");
            string ad = Console.ReadLine();
            Console.WriteLine("soyadınız: ");
            string soyad = Console.ReadLine();
            Console.WriteLine("adres: ");
            string adress = Console.ReadLine();
            if (menüSecim == 0)
            {
                toplambakiye += 150 * menüAdet;
                if (sosSecim == 2)
                {
                    toplambakiye += 10;
                }
            }
            else if (menüSecim == 1)
            {
                toplambakiye += 130 * menüAdet;
                if (sosSecim == 2)
                {
                    toplambakiye += 10;
                }
            }
            else if (menüSecim == 2)
            {
                toplambakiye += 200 * menüAdet;
                if (sosSecim == 2)
                {
                    toplambakiye += 10;
                }
            }
            Console.WriteLine("Siparişiniz oluşturuldu. Ödemeniz gereken toplam bedel " + toplambakiye);
            Console.WriteLine("");
            break;
        }
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
        Console.ReadLine();
        Console.Clear();
    }
} while (true);