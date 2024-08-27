/*
 NORTHWIND'E HOŞGELDİNİZ!
Aşağıdaki menüden işlem seçin:

1-Ürün İşlemleri
    1-Ürün Listesi
    2-Ürün Ekle
    3-Ürün Güncelle
    4-Ürün Sil

2-Sipariş İşlemleri
    1-Sipariş Listesi
    2-Sipariş Ekle
    3-Sipariş Güncelle
    4-Sipariş Sil

3-Tedarikçi İşlemleri
    1-Tedarikçi Listesi
    2-Tedarikçi Ekle
    3-Tedarikçi Güncelle
    4-Tedarikçi Sil

4-Nakliyeci İşlemleri
    1-Nakliyeci Listesi
    2-Nakliyeci Ekle
    3-Nakliyeci Güncelle
    4-Nakliyeci Sil

5-Müşteri İşlemleri
    1-Müşteri Listesi
    2-Müşteri Ekle
    3-Müşteri Güncelle
    4-Müşteri Sil

 seçim:
2
    1-Sipariş Listesi
    2-Sipariş Ekle
    3-Sipariş Güncelle
    4-Sipariş Sil
seçim:
    1
 Sipariş Listesi..
*/

int ürünislemleri = 1;
int siparisışlemleri = 2;
int tedarikçiIslemleri = 3;
int nakliyeciIslemleri = 4;
int müşteriIslemleri = 5;


string ürün =   "1-Ürün Listesi       2-Ürün Ekle    3-Ürün Güncelle   4-Ürün sil";
string siparis= "1-Sipariş Listesi    2-Sipariş Ekle   3-Sipariş Güncelle   4-Sipariş Sil";
string tedarik = "1-Tedarikçi Listesi  2-Tedarikçi Ekle  3-Tedarikçi Güncelle   4-Tedarikçi Sil";
string nakliye = "1-Nakliyeci Listesi    2-Nakliyeci Ekle   3-Nakliyeci Güncelle   4-Nakliyeci Sil";
string müsteri = "1-Müşteri Listesi    2-Müşteri Ekle    3-Müşteri Güncelle    4-Müşteri Sil";

Console.WriteLine(" NORTHWIND'E HOŞGELDİNİZ!");
Console.WriteLine("*************************** ");


Console.WriteLine("MENÜ");
Console.WriteLine("*******************");
Console.WriteLine("1-Ürün İşlemleri");
Console.WriteLine("2-Sipariş İşlemleri");
Console.WriteLine("3-Tedarikçi İşlemleri");
Console.WriteLine("4-Nakliyeci İşlemleri");
Console.WriteLine("5-Müşteri İşlemleri");
Console.WriteLine(" Yukarıdaki menüden işlem seçin: ");
int secim = int.Parse(Console.ReadLine());



switch (secim)
{
    case 1:
        Console.WriteLine(ürün);
        Console.WriteLine("istediğiniz ürün işlemini seceblirsiniz");
        string gelenürüntipi = Console.ReadLine();
        switch (gelenürüntipi)
        {
            case "1" :
                Console.WriteLine("1-Ürün Listesi  ");
                    break;
            case "2":
                Console.WriteLine("ürün  ekle");
                break;
            case "3":
                Console.WriteLine("ürün güncelle");
                break;
            case "4":
                Console.WriteLine("ürün sil");
                break;
            
        }
        break;
    case 2:
        Console.WriteLine(siparis);
        Console.WriteLine("istediğiniz sipariş işlemini seceblirsiniz");
        string gelensiparistipi = Console.ReadLine();
        switch (gelensiparistipi)
        {
            case "1":
                Console.WriteLine("sipariş listesi");
                break;
            case "2":
                Console.WriteLine("sipariş ekle");
                break;
            case "3":
                Console.WriteLine("sipariş güncelle");
                break;
            case "4":
                Console.WriteLine("sipariş sil");
                break;

        }
        break ;
    case 3:
        Console.WriteLine(tedarik);
        Console.WriteLine("istediğiniz tedarik işlemini seceblirsiniz");
        string gelentedariktipi= Console.ReadLine();
        switch (gelentedariktipi)
        {
            case "1":
                Console.WriteLine(" tedarik listesi");
                break;
            case "2":
                Console.WriteLine("tedarik ekle ");
                break;
            case "3":
                Console.WriteLine("tedarik güncelle");
                break;
            case "4":
                Console.WriteLine(" tedarik sil");
                break;

        }

        break;
        
    case 4:
        Console.WriteLine(nakliye);
        Console.WriteLine("istediğiniz nakliye işlemini seceblirsiniz");
        string gelennakliye = Console.ReadLine();
        switch (gelennakliye)
        {
            case "1":
                Console.WriteLine("nakliye listesi");
                break;
            case "2":
                Console.WriteLine("nakliye ekle");
                break;
            case "3":
                Console.WriteLine("nakliye güncelle");
                break;
            case "4":
                Console.WriteLine("nakliye sil");
                break;

        }

        break;
        
    case 5:

        Console.WriteLine(müsteri);
        Console.WriteLine("istediğiniz müşteri işlemini seceblirsiniz");
        string gelenmüsteri = Console.ReadLine();
        switch (gelenmüsteri)
        {
            case "1":
                Console.WriteLine("müsterilistesi");
                break;
            case "2":
                Console.WriteLine("müsteri ekle");
                break;
            case "3":
                Console.WriteLine("müsteri güncelle");
                break;
            case "4":
                Console.WriteLine("müsteri sil");
                break;

        }
        break;
}










      