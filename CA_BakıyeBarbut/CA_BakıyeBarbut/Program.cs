//Bakiye Barbut

//Uygulama çalıştığında Oyuncular için isimler alınacak.
//Her bir oyuncunun 500 puan'lık bakiyesi olacak.
//Oyun başlamadan önce birinci oyuncudan ortaya bir puan yatırılması istenecek.
//İkinci oyuncu birinci oyuncu puanı kadar ortaya yatıracak.
//oyun başlayacak.
//Kazanma durumuna göre ortadaki puan oyuncunun bakiyesine aktarılacak.

int puan1 = 500, puan2 = 500, istekPuan1, sonPuan1, sonPuan2;


Console.WriteLine("oyuncu 1 lütfen isminz girin: "); 
string kullanıcı1= Console.ReadLine();
Console.WriteLine("oyuncu 2 lütfen isminz girin: ");
string kullanıcı2= Console.ReadLine();
Console.WriteLine("Birinci oyuncu oynamak istediğiniz puan miktarını girin");
istekPuan1 = int.Parse(Console.ReadLine());

if (istekPuan1>0)
{
    
    Console.WriteLine(" kullanıcı 1 lütfen 'e' tuşuna  basınız");
    string tus1 = Console.ReadLine();
    if (tus1 == "e")
    {
        Random sözdesayı1 = new Random();
        int sayı1 = sözdesayı1.Next(1, 7);
        Console.WriteLine(sayı1);

        Console.WriteLine(" kullanıcı 2 lütfen 'e' tuşa basınız");
        string tus2 = Console.ReadLine();
        if (tus2 == "e")
        {
            Random sözdesayı2 = new Random();
            int sayı2 = sözdesayı2.Next(1, 7);
            Console.WriteLine(sayı2);
            if (sayı1 > sayı2)
            {
                Console.WriteLine($"{kullanıcı1} isimli oyuncu kazandı ");
                Console.WriteLine("puananız aktarılıyor......");
                sonPuan1 = puan1 + istekPuan1;
                sonPuan2 = puan2 - istekPuan1;
                Console.WriteLine($"{kullanıcı1}son puanın: {sonPuan1}");
                Console.WriteLine($"{kullanıcı2}son puanın: {sonPuan2}");
            }
            else if (sayı2 == sayı1)
            {
                Console.WriteLine($"{kullanıcı1} veya {kullanıcı2} oyunu kazanamdı oyun berabere ");
                Console.WriteLine("kimse puan alamadı");
            }
            else
            {
                Console.WriteLine($"{kullanıcı2} isimli  oyuncu kazandı ");
                sonPuan1 = puan1 - istekPuan1;
                sonPuan2 = puan2 + istekPuan1;
                Console.WriteLine($"{kullanıcı1}son puanın: {sonPuan1}");
                Console.WriteLine($"{kullanıcı2}son puanın: {sonPuan2}");
            }
        }
        else
        {
            Console.WriteLine("lütfen e tuşuna basınız");

        }

    }
    else
    {
        Console.WriteLine("lütfen e tuşuna basınız");
    }

}
else if (istekPuan1 > 500)
{
    Console.WriteLine("lütfen var olan puannız  kadar puan girin");
}
else if (istekPuan1 < 0)
{
    Console.WriteLine("lütfen negatif sayılar girmeiyn");
}
else
{
    Console.WriteLine("lütfen puan aralığınızda sayılar girin");
}
