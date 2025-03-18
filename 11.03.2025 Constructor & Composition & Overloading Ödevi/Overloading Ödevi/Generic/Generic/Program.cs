using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    //Constraint (Kısıtlama) ile sadece belirli türlerle çalışmasını sağlayabiliriz
    class veri<T> where T : class // T tipi referans türü olmalı
    {
        public T Deger { get; set; } // T tipinde bir değişken
    }
    class Sayi<T> where T : struct // T tipi değer türü olmalı
    {
        public T Deger { get; set; } // T tipinde bir değişken
    }
    //-----------------------------------------------------------------------------

    // Generic metot tanımı
    class Islemler
    {
        public void Yazdir<T>(T veri)
        {
            Console.WriteLine("Veri: " + veri);
        }
    }
    //------------------------------------------------------------------------------
   
    // Generic sınıf tanımı (T tipi ile çalışıyor)
    class Kutu<T>
    {
        private T icerik;

        public void Ekle(T veri) // Bu şekilde tanımlanır
        {
            icerik = veri;
        }

        public T Al() // Bu şekilde tanımlanır
        {
            return icerik; // T tipindeki icerik değişkenini döndürüyoruz
        }
    }
    //------------------------------------------------------------------------------
    class Program
    {
        static void Main()
        {
            // int tipi ile Kutu oluşturuyoruz
            Kutu<int> sayiKutusu = new Kutu<int>(); //<int> ile tip belirliyoruz
            sayiKutusu.Ekle(42);
            Console.WriteLine(sayiKutusu.Al()); 

            // string tipi ile Kutu oluşturuyoruz
            Kutu<string> metinKutusu = new Kutu<string>(); //<string> ile tip belirliyoruz
            metinKutusu.Ekle("Merhaba");
            Console.WriteLine(metinKutusu.Al()); 


            //Generic Methodlar
            Islemler islem = new Islemler();

            islem.Yazdir(100);     
            islem.Yazdir("Hello");  
            islem.Yazdir(3.14);
            //Metodun tipi çağırırken belirlenir, böylece esneklik sağlanır

            //Generic kısıtlamalar
            //Sadece belirli bir veri türü ile çalışmasını istiyorsak kısıtlama yapabiliriz
            veri<string> veri1 = new veri<string>();
            veri1.Deger = "Merhaba";
            Sayi<int> sayi1 = new Sayi<int>();
            sayi1.Deger = 42;
        }
    }

}
