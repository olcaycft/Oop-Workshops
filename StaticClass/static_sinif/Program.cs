using System;

namespace static_sinif
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(Calisan.CalisanSayisi);
            Calisan calisan1 = new Calisan("Olcay","ÇİFTÇİ","Yazılım");
            Console.WriteLine(Calisan.CalisanSayisi);
            Calisan calisan2 = new Calisan("Olcay", "ÇİFTÇİ", "Yazılım");
            Console.WriteLine(Calisan.CalisanSayisi);
            Calisan calisan3 = new Calisan("Olcay", "ÇİFTÇİ", "Yazılım");
            Console.WriteLine(Calisan.CalisanSayisi);
            Calisan calisan4 = new Calisan("Olcay", "ÇİFTÇİ", "Yazılım");
            Console.WriteLine(Calisan.CalisanSayisi);

            Console.WriteLine(Islemler.Topla(45,123));
            Console.WriteLine(Islemler.Cikar(45, 123));


        }
    }

}
