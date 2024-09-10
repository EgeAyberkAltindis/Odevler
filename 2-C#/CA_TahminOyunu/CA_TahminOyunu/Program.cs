//Uygulama çalıştığında arkaplan 1 ile 10 arasında rastgele bir sayı tutulsun.
//kullanıcı bir sayı tahmin etsin. Kullanıcın tahmin etmiş olduğu sayı tutulan sayıdan küçük ise "lütfen daha büyük bir sayı girin" eğer sayı tutulan sayıdan büyük ise "lütfen daha küçük birsayı girin. tutulan girilen sayıya eşit ise "tebrikler doğru tahmin"

//oyun başlangıçta 1.seviyede başlayacak. (1-10 arasında sayı tutuar)
//Her doğru tahminde seviye bir kez artırılsın.(1 ile 20)

//kullanıcının 5 tahmin hakkı olacak. Her yanlış tahminde 1 kez azaltılacak. Tahmin 0 olduğunda oyun bityecek. Doğru tahminde hak 5 olarak güncellenecek.

//int can = 5;
//int i = 1;
//int tahmin = 0;
//int maxSayi = 11;

//Console.WriteLine("Tahmin Oyunu");
//Console.WriteLine("**");
//Random rnd = new Random();

//Console.WriteLine("oyun 3 seviyeden oluşuyor");
//Console.WriteLine("oyunun 1'inci seviyesinden başlıyorsun");

//while (3 > i && can != 0)
//{
//    int gelensayı = rnd.Next(1, maxSayi);
//    Console.WriteLine($"Gelen sayı {gelensayı}");
//    while (can > 0)
//    {
//        Console.WriteLine("zarı tahmin et");
//        try
//        {
//            tahmin = int.Parse(Console.ReadLine());
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine(ex.Message);
//            break;
//        }


//        if (tahmin == gelensayı)
//        {
//            i++;
//            can = 5;
//            maxSayi += 10;
//            if (i == 3)
//            {
//                Console.WriteLine("TAHMİN OYNUNU KAZANDIN!");
//            }
//            else
//            {
//                Console.WriteLine($"tahmin doğru tebrikler, yeni seviye: {i}");
//            }
//            break;
//        }
//        else if (tahmin > gelensayı)
//        {
//            Console.WriteLine("tahmin gelen sayıdan daha büyüktür tekrar deneyiniz");
//            can--;
//            Console.WriteLine($"Kalan can {can}");
//            if (can == 0)
//            {
//                Console.WriteLine("CAN BİTTİ!");
//            }
//        }
//        else if (tahmin < gelensayı)
//        {
//            Console.WriteLine("tahmin gelen sayıdan daha küçüktür tekrar deneyiniz");
//            can--;
//            Console.WriteLine($"Kalan can {can}");
//            if (can == 0)
//            {
//                Console.WriteLine("CAN BİTTİ!");
//            }
//        }
//    }
//}
using System.Net.WebSockets;

int i = 0;
int can = 5;
int maxsayi = 11;
int sayı = 0;

Console.WriteLine("Tahmin Oyunu");
Console.WriteLine("***************");
Console.WriteLine("Oyuna Hoşgeldiniz");
Random rast = new Random();
while (i<3&&can!=0)
{
     int gelensayi = rast.Next(1,maxsayi);
    Console.WriteLine("lütfen bir sayı tahmn ediniz");
    Console.WriteLine($"gelen sayı : {gelensayi}");
   
    while (can > 0)
        
    {try
        {
            sayı = int.Parse(Console.ReadLine());
        }
        catch (Exception e)
        {
            Console.WriteLine (e.Message);
            break;
        }
         
        if (gelensayi==sayı)
        {
            i++;
            can = 5;
            maxsayi += 10;
            if (i == 3) 
            {
                Console.WriteLine("Oyunu Kazanadınız Tebrikler");
            }
            else
            {
                Console.WriteLine($"tebrkler level {i} olmaya hak kazandınız");
                Console.WriteLine($"canınız {can} oldu");
            }
            break;
        }
        else if (gelensayi<sayı)
        {
            can--;
            if (can==0)
            {
                Console.WriteLine("oyun bitti");
                
            }
            else
            {
                Console.WriteLine("mevcut canız: " + can);
                Console.WriteLine("lütfen daha küçük bir sayı giriniz");
                
            }
            
        }
        else if (gelensayi>sayı)
        {
            can--;
            if (can == 0)
            {
                Console.WriteLine("oyun bitti");

            }
            else
            {
                Console.WriteLine("mevcut canız: " + can);
                Console.WriteLine("lütfen daha büyük bir sayı giriniz");
                
            }
            
        }
    }
}
