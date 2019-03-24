using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading.Tasks;

namespace DZ2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person()
            {
                Name = "Muratzhan",
                Age = 16,
                City = "Nursultan"
            };
            Type type = typeof(Person);
            Console.WriteLine("Тип: " + type.Name);
            PropertyInfo[] properties = type.GetProperties();
            Console.WriteLine("Методы: ");
            foreach (var property in properties) {
                    Console.WriteLine(property.PropertyType + ":\t" + property.Name);
            }
            Console.Read();
        }
    }
}
