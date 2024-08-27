string su, yağ, krema, pestosos, makarna, pişmismakarna;


Console.WriteLine("Pesto Soslu Makarna");
Console.WriteLine("***********************");
Console.WriteLine("Bügünki yemeğimi yaparken bana eşlik et!");



Console.WriteLine("malzemeleri belirle!");

Console.WriteLine("kaç bardak su alıcaksın?: ");
su=Console.ReadLine();
short bardaksayısı = Convert.ToInt16(su);
Console.WriteLine("bir bardağın ne kadarına yağ koyacaksın?: ");
yağ = Console.ReadLine();
Console.WriteLine("kaç paket makarna koyacaksın?: ");
makarna= Console.ReadLine();
short paketmiktarı = Convert.ToInt16(makarna);
Console.WriteLine("kaç şise pesto sos koyacaksın?: ");
pestosos  = Console.ReadLine();
short sısemıktarı = Convert.ToInt16(pestosos);
Console.WriteLine("kaç paket krema koyacaksın");
krema= Console.ReadLine();
short paketkrema=Convert.ToInt16(krema); 

Console.WriteLine(" tarfi birlkte yapalım");

Console.WriteLine("tencereyi al 90 derece sağındaki ocağa koy"); 
Console.WriteLine("90 derece dön süzgeci al 90 derece dön süzgeci lavobonun üstüne koy");


Console.WriteLine(bardaksayısı+" bardak suyu geitir tencerin üstüne koy elini 60 derece döndür saat yöünün tersine ve suyun sıcaklığının 100 derece olmasını bekle");

Console.WriteLine("tavanın içine " + sısemıktarı + "," + yağ + "koy karıştır");
Console.WriteLine(paketmiktarı + "tencerenin içine koy");
Console.WriteLine("tencereyi kaşık ile 50 defa sekiz çiz");

string kremaasaması = $"{paketkrema}  kadar koy ve 50 defa saat yönünden döndür";
Console.WriteLine(kremaasaması);
pişmismakarna = Console.ReadLine();
Console.WriteLine(pişmismakarna + "al ve süzgecin üstüne koy");
Console.WriteLine("süzgeci tencereye üsütne getir elini 90 derce döndür ve süzgeci lavobaya bırak");
Console.WriteLine("sosu tencereye dök");



