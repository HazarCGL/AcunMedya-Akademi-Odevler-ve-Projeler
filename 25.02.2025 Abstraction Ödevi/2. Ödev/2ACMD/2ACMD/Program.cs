internal class Program
{
    private static void Main(string[] args)
    {
        GMudur gMudur = new GMudur();
        Mudur mudur = new Mudur();
        Programci programci = new Programci();
        Stajer stajer = new Stajer();

        gMudur.PersonelPozisyon = "Genel Mudur";
        Console.Write(gMudur.PersonelPozisyon);
        gMudur.Maas();

        mudur.PersonelPozisyon = "Mudur";
        Console.Write(mudur.PersonelPozisyon);
        mudur.Maas();

        programci.PersonelPozisyon = "Programci";
        Console.Write(programci.PersonelPozisyon);
        programci.Maas();

        stajer.PersonelPozisyon = "Stajer";
        Console.Write(stajer.PersonelPozisyon);
        stajer.Maas();
    }
    interface IMaas
    {
        void Maas();
    }

    abstract class Calisan
    {
       public string PersonelPozisyon;
    }

    class GMudur : Calisan, IMaas
    {
        public void Maas()
        {
            Console.WriteLine(" --> 80.000");
        }
    }

    class Mudur : Calisan, IMaas
    {
        public void Maas()
        {
            Console.WriteLine("Mudur --> 60.000");
        }
    }

    class Programci : Calisan, IMaas
    {
        public void Maas()
        {
            Console.WriteLine("Programcı --> 40.000");
        }
    }

    class Stajer : Calisan, IMaas
    {
        public void Maas()
        {
            Console.WriteLine("Stajer --> 5.000");
        }
    }
}