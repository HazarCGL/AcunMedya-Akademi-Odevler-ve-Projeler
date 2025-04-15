using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionÖdevi
{

    internal class Program
    {
        // Reflection, bir nesnenin türü hakkında bilgi edinmek için kullanılan bir mekanizmadır.
        // Bu mekanizma sayesinde, bir nesnenin özelliklerine, metodlarına ve diğer bileşenlerine dinamik olarak erişebiliriz.
        // Reflection, genellikle aşağıdaki durumlarda kullanılır:
        // 1. Dinamik tip oluşturma: Programın çalışma zamanında tür bilgisi edinmek için kullanılır.
        // 2. Dinamik nesne oluşturma: Programın çalışma zamanında yeni nesneler oluşturmak için kullanılır.
        // 3. Dinamik metod çağrısı: Programın çalışma zamanında bir nesnenin metodunu çağırmak için kullanılır.
        // 4. Dinamik özellik erişimi: Programın çalışma zamanında bir nesnenin özelliklerine erişmek için kullanılır.
        // 5. Dinamik tür bilgisi edinme: Programın çalışma zamanında bir nesnenin tür bilgisine erişmek için kullanılır.

        // Örnek bir sınıf oluşturalım
        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public void Greet()
            {
                Console.WriteLine($"Merhaba, benim adım {Name} ve ben {Age} yaşındayım.");
            }
        }
        static void Main(string[] args)
        {
            //nesnenin adı Hazar ve yaşı 19 olsun
            Person person = new Person { Name = "Hazar", Age = 19 };
            person.Greet();
            // Reflection kullanarak bir nesnenin tür bilgisine erişelim
            Type type = typeof(Person);
            Console.WriteLine("Nesne Türü: " + type.Name);
            // Reflection kullanarak bir nesnenin özelliklerine erişelim
            var properties = type.GetProperties();
            Console.WriteLine("Özellikler:");
            foreach (var property in properties)
            {
                Console.WriteLine(property.Name);
            }
            // Reflection kullanarak bir nesnenin metodlarına erişelim
            var methods = type.GetMethods();
            Console.WriteLine("Metodlar:");
            foreach (var method in methods)
            {
                Console.WriteLine(method.Name);
            }
            Console.ReadKey();
        }
    }
}
