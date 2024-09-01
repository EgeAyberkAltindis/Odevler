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
                while (true)
                {
                    //Console.WriteLine("bir isim girin");
                    //string ısım = Convert.ToString(Console.ReadLine());

                    //for (int i = 0; i <employee.FirstName.Length; i++) 
                    //{

                    //    if (employee.FirstName[i] == ısım)
                    //    {
                    //        müsteri.Isım(ısım);
                    //    }
                    //}


                    //Console.WriteLine( "bir sayı girin");
                    //int sayı1 = int .Parse(Console.ReadLine());
                    //urun.Islem1(sayı1);

                    //Console.WriteLine("bir sayı girin");
                    //int sayı1 = int.Parse(Console.ReadLine());
                    //Console.WriteLine( "bir sayı daha girin");
                    //int sayı2 = int.Parse(Console.ReadLine());
                    //urun.Islem2(sayı1, sayı2);

                    urun.AdetBul();
                    
                }




            }
            catch (Exception ex) 
            { 
                Console.WriteLine(ex.Message);
            }
        }
    }
}