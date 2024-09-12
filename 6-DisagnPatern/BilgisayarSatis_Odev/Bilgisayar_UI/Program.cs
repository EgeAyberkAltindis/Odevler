
using Bilgisayar_Dal.Factory;
using Bilgisayar_Dal.Factory.Abstract;
using Bilgisayar_Dal.Factory.Concretes;
using Bilgisayar_Dal.Migrations;
using Microsoft.EntityFrameworkCore.Migrations;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

BilgisayarBuilder laptop = new LaptopBuilder();

BİlgisayarKullan bilgisayarKullan= new BİlgisayarKullan();
bilgisayarKullan.Kullan(laptop);

Console.WriteLine(laptop.Bilgisayar);
//add-migration initialBiglisayarSatis -o Migrations
/*
 * //Builder Pattern kullanarak Bir Bilgisayar satış mağazası için;

//Ofis bilgisayarı
//Oyun bilgisayarı
//Laptop

nesnelerini oluşturmayı hedefleyen Builder Paterni uygulayın.

Bilgayar.cs

marka,
model,
ram,
ekrankartı,
anakart,
işlemci

//Veritabanında bilgisayar parçaları bulunsun.
//Console uygulaması oalrak veritabanı ile ilişkilendirip verileri veritabanından çekerek kullanıcıların Oyun bilgisayarı ya da ofis bilgisayarı toplamalarını sağlayın.
 */