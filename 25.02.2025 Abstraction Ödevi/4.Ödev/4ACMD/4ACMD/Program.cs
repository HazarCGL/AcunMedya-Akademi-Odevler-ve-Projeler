internal class Program
{
    private static void Main(string[] args)
    {
        /*
--------------------------------------------------
               _____  _____        __     __
         /\   |  __ \|  __ \     /\\ \   / /
        /  \  | |__) | |__) |   /  \\ \_/ / 
       / /\ \ |  _  /|  _  /   / /\ \\   /  
      / ____ \| | \ \| | \ \  / ____ \| |   
     /_/    \_\_|  \_\_|  \_\/_/    \_\_|  
--------------------------------------------------
        Arrayler bir isim altında bir veri grubu oluşturmaya yarar
        */
        String[] Cars = { "BMW", "Mustang", "Corvette" };//Array Olşuturmak İçin veri tipinin başına [] bu işareti koymak gerekir
        Cars[0] = "Tesla";//Dizi içerisinden Veri seçmek için "ArrayAdı[0]" ayrıca belirli bir veriye yeni bir atama yapmak içinde bu yöntem kullanılır.
                          //ayrıca arraylarde 0 dan başlamak gerekir
                          //yani 1. değer için 0
                          //2. değer için 1
                          //3. değer için 2
                          //n. değer için n-1 gibi
                          //bir for loop örneği ile bütün araçları yazdıralım
        for (int i = 0; i < Cars.Length; i++)
        {
            Console.WriteLine(Cars[i]);
        }


    }
}