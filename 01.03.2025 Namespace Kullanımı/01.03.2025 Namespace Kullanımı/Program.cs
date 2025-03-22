using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




//Name Space Kullanmanın Avantajları
//1.Aynı isime sahip sınıfları birbirinden ayırt etmek için kullanılır.
//2.Kodun düzenli ve anlaşılır olmasını sağlar.
//3.Aynı isimdeki sınıfları farklı namespace'lerde kullanabiliriz.
//4.Aynı isime sahip sınıfları farklı namespace'lerde kullanabiliriz.
//5.Proje genişletildiğinde yeni kodların eski kodlarla uyumlu olmasını kolaylaştırır.
namespace _01._03._2025_Namespace_Kullanımı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hesaplama.Hesap hesap = new Hesaplama.Hesap();
            Console.WriteLine(hesap.Topla(25, 56));
            Console.WriteLine(hesap.carp(34, 26));
            Console.ReadLine();
        }
    }
}
namespace Hesaplama
{
   public class Hesap
    {
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        public int carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
    }
}
