//ÖDEV

//Uygulama çalıştırıldığında 1.Oyuncu için bir isim alın ardından 2. Oyuncu için bir isim alın.
//1. Oyuncu bir tuşa (e) bassın ve bir zar atsın.
//2. Oyuncu bir tuşa (e) bassın ve bir zat atsın.
//2. oyuncu zarı attıktan sonra sonuç belirlensin.
//Eğer birinci ikinci oyuncunun zarından daha bir değer atmışsa "1. oyuncunun ismi kazandı",
//Eğer ikinci birinci oyuncunun zarından daha bir değer atmışsa "2. oyuncunun ismi kazandı",
//Aynı değerler olması durumunda "Oyun berabere" mesajını console'da yazdırın.

Console.WriteLine("kullacı 1 isminizi girin: ");
string kullanıcı1 = Console.ReadLine();

Console.WriteLine("kullanıcı 2 ismini giriniz: ");
string kullanıcı2 = Console.ReadLine();


Console.WriteLine(" kullanıcı 1 e tuşuna  basınız");
string tus1 = Console.ReadLine();
if (tus1 == "e")
{
    Random sözdesayı1 = new Random();
    int sayı1 = sözdesayı1.Next(1, 7);
    Console.WriteLine(sayı1);

    Console.WriteLine(" kullanıcı 2 bir tuşa basınız");
    string tus2 = Console.ReadLine();
    if (tus2 == "e")
    {
        Random sözdesayı2 = new Random();
        int sayı2 = sözdesayı2.Next(1, 7);
        Console.WriteLine(sayı2);
        if (sayı1 > sayı2)
        {
            Console.WriteLine($"{kullanıcı1} isimli oyuncu kazandı ");
        }
        else if (sayı2 == sayı1)
        {
            Console.WriteLine($"{kullanıcı1} veya {kullanıcı2} oyunu kazanamdı oyun berabere ");
        }
        else
        {
            Console.WriteLine($"{kullanıcı2} isimli  oyuncu kazandı ");
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







