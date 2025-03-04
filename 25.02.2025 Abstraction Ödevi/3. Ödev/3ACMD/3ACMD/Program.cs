internal class Program
{
    private static void Main(string[] args)
    {
        BMW bMW = new BMW();
        Mercedes mercedes = new Mercedes();
        Porsche porsche = new Porsche();

        bMW.KapiSayisi = 4;
        bMW.Marka = "BMW -> ";
        bMW.Speed = 330;
        Console.Write(bMW.Marka);
        bMW.YakitHesap();

        mercedes.KapiSayisi = 4;
        mercedes.Marka = "Mercedes -> ";
        mercedes.Speed = 299;
        Console.Write(mercedes.Marka);
        mercedes.YakitHesap();

        porsche.KapiSayisi = 2;
        porsche.Marka = "Porsche -> ";
        porsche.Speed = 450;
        Console.Write(porsche.Marka);
        porsche.YakitHesap();

    }

    interface IYakit
    {
        public void YakitHesap();
    }

    abstract class VehicleProp
    {
        public int KapiSayisi;
        public int Speed;
        public string Marka;
    }

    class BMW : VehicleProp, IYakit
    {
        public void YakitHesap()
        {
            Console.WriteLine("80.0L");
        }
    }

    class Mercedes : VehicleProp, IYakit
    {
        public void YakitHesap()
        {
            Console.WriteLine("70.0L");
        }
    }

    class Porsche : VehicleProp, IYakit
    {
        public void YakitHesap()
        {
            Console.WriteLine("60.0L");
        }
    }
}