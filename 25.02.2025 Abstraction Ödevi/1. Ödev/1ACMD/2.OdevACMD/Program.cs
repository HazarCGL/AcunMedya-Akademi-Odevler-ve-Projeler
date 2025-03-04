using System.Reflection.Metadata;

internal class Program
{
    private static void Main(string[] args)
    {
        BMW bMW = new BMW();
        Mercedes mercedes = new Mercedes();
        Porsche porsche = new Porsche();

        Console.Write("BMW: ");
        bMW.Speed();
        bMW.Swim();
        bMW.Fly();
        Console.Write("Mercedes: ");
        mercedes.Swim();
        mercedes.Fly();
        Console.Write("Porsche: ");
        porsche.Fly();
    }
    interface ISpeed
    {
        public void Speed();
    }
    interface IFly
    {
        public void Fly();
    }

    interface ISwim
    {
        public void Swim();
    }

    class BMW : ISpeed, IFly, ISwim
    {

        public void Speed()
        {
            Console.Write("Çok Hızlı Gider. ");
        }

        public void Fly()
        {
            Console.WriteLine("Havada Uçar ");
        }
        public void Swim()
        {
            Console.Write("Denizde Yüzer ");
        }
    }

    class Mercedes : IFly, ISwim
    {
        public void Fly()
        {
            Console.WriteLine("Havada Uçar ");
        }
        public void Swim()
        {
            Console.Write("Denizde Yüzer ");
        }
    }

    class Porsche : IFly
    {
        public void Fly()
        {
            Console.WriteLine("Havada Uçar ");
        }
    }

}