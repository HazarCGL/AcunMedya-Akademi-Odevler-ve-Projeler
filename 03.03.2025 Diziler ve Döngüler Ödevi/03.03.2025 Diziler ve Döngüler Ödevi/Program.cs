using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._03._2025_Diziler_ve_Döngüler_Ödevi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayi = new int[5];
            Console.WriteLine("5 adet sayı giriniz: ");
            for (int i = 0; i < 5; i++)
            {
                sayi[i] = Convert.ToInt32(Console.ReadLine());
            }
            int toplam = 0;
            for (int i = 0; i < 5; i++)
            {
                toplam += sayi[i];
            }
            int ortalama = toplam / sayi.Length;
            Console.WriteLine("Girdiğiniz sayilarin ortalaması: " + ortalama);
        }
    }
}
