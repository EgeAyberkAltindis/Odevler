
Console.WriteLine(" 6 kolonluk loto oynmak isterseniz e tuşuna basın");
ConsoleKeyInfo anahtar = Console.ReadKey();
while (anahtar.Key == ConsoleKey.E)
{
        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine("");
            for (int j = 0; j < 6; j++)
            {
                    Random rnd = new Random();
                    int loto = rnd.Next(1, 50);
                    Console.Write(loto + " ");                                           
            }
        }
    Console.WriteLine( "");
    Console.WriteLine("eğer tekrar sayı almak isterseniz e tuşuna basın");
    Console.ReadKey();
}






