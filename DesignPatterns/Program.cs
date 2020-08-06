using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<DesignPatterns> list = new List<DesignPatterns>()
            {
                new DesignPatterns() { Name = "Singleton Pattern", Category="Creational Pattern", Description ="Creates an objects."},
                new DesignPatterns() { Name = "Abstract Factory Pattern", Category="Creational Pattern", Description ="Creates an objects abstract factory."}
            };

            foreach (var item in list)
            {
                Console.WriteLine($" Name : {item.Name}");
            }
            Console.ReadKey();
        }
    }

    class DesignPatterns
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
    }
}
