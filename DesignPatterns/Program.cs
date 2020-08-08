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
                new DesignPatterns() { Name = "Singleton Pattern", Category="Creational Pattern", 
                    Description ="Creates an objects.", 
                    DateLearnt = new DateTime(2020,8,4) },
                new DesignPatterns() { Name = "Abstract Factory Pattern", Category="Creational Pattern", 
                    Description ="Creates an objects abstract factory.", 
                    DateLearnt = new DateTime(2020,8,8)},
                new DesignPatterns() { Name = "Adapter Pattern", Category="Structural Pattern", 
                    Description ="Converts the interface of a class into another interface that a client wants.", 
                    DateLearnt = new DateTime(2020,8,10)},
                new DesignPatterns() { Name = "Command", Category="Behavioral Pattern", 
                    Description ="encapsulate a request under an object as a command and pass it to invoker object.", 
                    DateLearnt = new DateTime(2020,8,10)}
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
        public DateTime DateLearnt { get; set; }
    }
}
