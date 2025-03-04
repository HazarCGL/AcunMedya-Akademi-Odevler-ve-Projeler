interface ISpeed
{
    void Speed();
}
interface ISwim
{
    void Swim();
}
interface IFly
{
    void Fly();
}
class BMW : ISpeed, IFly, ISwim
{
    public void Speed()
    {
        Console.WriteLine("BMW: Çok hızlı gider, denizde yüzer, havada uçar.");
    }
}
class Porsche : IFly
{
    public void Fly()
    {
        Console.WriteLine("Porsche: Havada uçar.");
    }
}
class Mercedes : IFly, ISwim
{
    public void Swim()
    {
        Console.WriteLine("Mercedes: Denizde yüzer, havada uçar.");
    }
}
Mercedes mercedes = new Mercedes();
BMW bMW = new BMW();
Porsche porsche = new Porsche();

bMW.Speed();
mercedes.Swim();
porsche.Fly();