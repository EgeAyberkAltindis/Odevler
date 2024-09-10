//Bakiye İşlemi

//Uygulama çalıştığında kullanıcın varsayılan 500 TL bakiyesi olsun. aşağıdaki menü karşılasın.

//**İŞLEM * *
//1-Para Çek
//2-Para Yatır
//3-Bakiye Görüntüle
//işlem:1
//Miktar: 500
//Bakiyeniz yetersiz.

using System.ComponentModel.Design;

int bakiye = 500;
int bakiyegörütüleme= 1;
int paracek = 2;
int parayatır= 3;


Console.WriteLine("IŞLEMLER");
Console.WriteLine("1-Bakiye Görüntüleme");
Console.WriteLine("2-Para Çek");
Console.WriteLine("3-Para Yatır");
Console.WriteLine(" lütfen bir işlem tipi (işlemin numarasını) giriniz");
int durum = int.Parse(Console.ReadLine());
if (durum == 1 || durum == 2 || durum == 3)
{
    if (durum == 1)
    {
        Console.WriteLine("bakiyeniz: " + bakiye);
    }
    else if (durum == 2)
    {
        Console.WriteLine("lütfen girilecek tutarı giriniz");
        int cektutar = int.Parse(Console.ReadLine());
        if (cektutar <= bakiye)
        {
            int yatırlanPara = bakiye- cektutar;
            Console.WriteLine("Yeni Bakiyeniz: "+yatırlanPara);
        }
        else if (cektutar > 0)
        {
            Console.WriteLine("lütfen doğru değer değer aralığında giriniz");
        }
        else
        {
            Console.WriteLine("böyle bir işem yapılamıyor yetersiz bakiye");
        }
    }
    else if (durum == 3)
    {
        Console.WriteLine("Yatırmak Istediğiniz Miktari Girin:");
        int alpara = int.Parse(Console.ReadLine());
        if (alpara>0)
        {
            int yeniBakiye = alpara + bakiye;
            Console.WriteLine("mevcut bakiyrniz: "+yeniBakiye);
        }
        else
        {
            Console.WriteLine("lütfen doğru bir aralık giriniz");
        }
        
    }

}
else
{
   Console.WriteLine("yanlış işlem tipi girdiniz");
}