//Scaffold-DbContext "server=DESKTOP-ABTB3OG\SQLEXPRESS;database=NORTHWİND;Trusted_Connection=True;TrustServerCertificate=True" Microsoft.EntityFrameworkCore.SqlServer -o Models

using CA_NortwindVeriTabanı.Concretes;
using CA_NortwindVeriTabanı.Models;
using Microsoft.Identity.Client;
using System.Runtime.CompilerServices;


namespace NorthwindVeriTabanı
{
    class Program
    {
        public static void Main(string[] args)
        {
            NorthwİndContext db = new NorthwİndContext();
            Employees müsteri = new Employees();
            Employee employee = new Employee(); 
            Urun urun = new Urun();

            try 
            {
                Console.WriteLine("bir isim girin");
                string ısım = Convert.ToString(Console.ReadLine());
            
                Console.WriteLine("soyad eklemek istermisiniz? evet/hayır");
                string cevap = Console.ReadLine();
                if (cevap == "evet")
                {
                    Console.WriteLine("soyad giriniz");
                    string soyad = Console.ReadLine();
                    müsteri.IsımSoyad(ısım, soyad);
                }
                else
                {
                    müsteri.Isım(ısım);
                }
                    
                while (true)
                {
                    

                   

                    //Console.WriteLine( "bir sayı girin");
                    //int sayı1 = int .Parse(Console.ReadLine());
                    //urun.Islem1(sayı1);

                    //Console.WriteLine("bir sayı girin");
                    //int sayı1 = int.Parse(Console.ReadLine());
                    //Console.WriteLine( "bir sayı daha girin");
                    //int sayı2 = int.Parse(Console.ReadLine());
                    //urun.Islem2(sayı1, sayı2);



                }




            }
            catch (Exception ex) 
            { 
                Console.WriteLine(ex.Message);
            }
        }
    }
}