// See https://aka.ms/new-console-template for more information
using AcunMedyaAkademi_İnheritance_Ödev;

Console.WriteLine("-------------OTOPARK TAKİP PROGRAMI-------------");
Audi audi = new Audi();
Mercedes mercedes = new Mercedes();
Togg togg = new Togg();

audi.Marka = "AUDİ    ";
audi.VitesTipi = "Otomatik";
mercedes.Marka = "MERCEDES";
mercedes.VitesTipi = "Manuel";
togg.Marka = "Togg    ";
togg.VitesTipi = "Otomatik";

audi.AracaKalkis();
mercedes.AracaKalkis();
togg.AracaKalkis();