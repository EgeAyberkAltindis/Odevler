using CA_BoynerSecim;
using System.Collections;

ArrayList boyner = new ArrayList();

Giyim giysi = new Giyim();
giysi.Marka = "koton";
giysi.beden = "m";
giysi.Fiyat = 5000m;
boyner.Add(giysi);

Gida yemek = new Gida();
yemek.Tadı = "tuzlu";
yemek.SonKullanmaTarihi = DateTime.Now;
yemek.Fiyat = 200m;
boyner.Add(yemek);


Elektronik elektronik = new Elektronik();
elektronik.Marka = "laptop";
elektronik.Fiyat = 100000m;
boyner.Add(elektronik);

Kozmetik kozmetik = new Kozmetik();
kozmetik.Marka = "yüz bakım jeli";
kozmetik.Fiyat = 4000m;
boyner.Add(kozmetik);

foreach (object Urun in boyner)
{
    if (Urun is Giyim)
    {
        Giyim giyim = (Giyim)Urun;
        Console.WriteLine( giyim.Fiyat);
        giyim.KdvliFiyat(5000m);
    }
    else if (Urun is Gida)
    {

    }
    else if (Urun is Elektronik)
    {

    }
    else if (Urun is Kozmetik)
    {

    }
}