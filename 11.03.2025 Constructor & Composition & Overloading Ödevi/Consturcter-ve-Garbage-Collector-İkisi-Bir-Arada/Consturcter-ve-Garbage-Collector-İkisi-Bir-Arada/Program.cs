using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consturcter_ve_Garbage_Collector_İkisi_Bir_Arada
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                new Araba($"Araba {i}");//Bu şekilde Destructor ve Garbage Collector Metodunun Çalıştığını Görebiliriz.
            }
            Araba araba1 = new Araba("Audi", 2010);//Bu şekilde constructor metotu çalıştırılır.
            Araba araba2 = new Araba("BMW", 2015);//Bu şekilde tek tek yazmak yerine constructor metotu kullanılır.
            Console.WriteLine("---------------------------------------------------------------");
            GC.Collect();//Kullanılmayan nesneleri otomatik olarak bellekten temizler ama bu şekilde Manuel olarakda Çağırılabilir.
            GC.WaitForPendingFinalizers();
            //GC.Collect() genellikle kullanılmaz çünkü C# zaten bellek yönetimini otomatik olarak yapar.
            //Ancak test veya performans izleme amacıyla kullanılabilir.
            Console.WriteLine("Garbage Collector çalıştırıldı.");
            Console.ReadLine();
            //C#’ta bellek yönetimi otomatik olduğu için çoğu zaman Garbage Collector’a
            //manuel müdahale etmeye gerek yoktur.
            //Ancak Destructor, belirli kaynakları serbest bırakmak için özel durumlarda kullanılabilir.

        }
    }
    class Araba
    {
        //Constructor metotu Bu şekilde tanımlanır.
        public string marka;
        public int yil;
        public string renk;
        public Araba(string marka, int yil)//Constructor metotu class ile aynı isimde olmalıdır.
        {

            this.marka = marka;//this anahtar kelimesi bu class'ı temsil eder.
            this.yil = yil;

            Console.WriteLine($"{marka} {yil} nesnesi oluşturuldu.");
        }
        public Araba(string renk)//Birden fazla constructor metotu oluşturulabilir Overloading.
        {
            this.renk = renk;
            Console.WriteLine($"{renk} nesnesi oluşturuldu.");
        }

        ~Araba()//Destructor metotu Bu şekilde tanımlanır.
        {
            Console.WriteLine($"{marka} Nesnesi Bellekten Siliniyor");//Destructor program sonlandığında veya Garbage Collector tarafından çağrıldığında çalışır.
        }

    }
}
