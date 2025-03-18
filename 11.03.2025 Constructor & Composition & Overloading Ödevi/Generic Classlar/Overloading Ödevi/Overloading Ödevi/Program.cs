using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading_Ödevi
{
    class Math
    {
        public void Topla(int a, int b)
        {
         Console.WriteLine($"Toplam : {a + b}");
        }
        public void Topla(double a, double b)
        {
            Console.WriteLine($"Toplam : {a + b}");
        }

        public void Cikar(int a, int b)
        {
            Console.WriteLine($"Fark : {a - b}");
        }
        public void Cikar(double a, double b, double c)
        {
            Console.WriteLine($"Fark : {a - b - c}");
        }
        public void Carp(int a, int b)
        {
            Console.WriteLine($"Çarpım : {a * b}");
        }
        public void Carp(double a, double b, double c)
        {
            Console.WriteLine($"Çarpım : {a * b * c}");
        }
        public void Bol(int a, int b)
        {
            Console.WriteLine($"Bölüm : {a / b}");
        }
        public void Bol(double a, double b, double c)
        {
            Console.WriteLine($"Bölüm : {a / b / c}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
         Math math = new Math();
         math.Topla(5, 10);
         math.Topla(5.5, 10.5);
         math.Cikar(10, 5);
         math.Cikar(10.5, 5.5, 2.5);
         math.Carp(5, 10);
         math.Carp(5.5, 10.5, 2.5);
         math.Bol(10, 5);
         math.Bol(10.5, 5.5, 2.5);
         Console.ReadLine();
        }
    }
}
