using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sayı_Tahmin_Oyunu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(1,10); // 0 ile int.MaxValue arasında rastgele sayı üretir.
            int guess = 0; // Kullanıcının tahmin ettiği sayı.
            int count = 0; // Kullanıcının kaçıncı tahminde bildiğini tutar.
            while (guess != randomNumber) // Tahmin doğru olana kadar döngü devam eder.
            {
                Console.Write("Bilgisayar 1 ile 10 arasında bir sayı tuttu. Tahmininizi giriniz: ");
                guess = Convert.ToInt32(Console.ReadLine()); // Kullanıcının tahminini alır.
                count++; // Tahmin sayısını bir arttırır
                if (guess == randomNumber) // Eğer tahmin doğruysa tebrik mesajı verir.
                {
                    Console.WriteLine($"Tebrikler, {count}. tahminde bildiniz.");
                }
            }
        }
    }
}
