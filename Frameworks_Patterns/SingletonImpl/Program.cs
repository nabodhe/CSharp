using System;

namespace SingletonImpl
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Singleton Pattern!");
            MySingleton s1 = MySingleton.Instance;
            Console.WriteLine($"s1 = {s1.Name} Num = {s1.Number}");
            MySingleton s2 = MySingleton.Instance;
            Console.WriteLine($"s2 = {s2.Name} Num = {s2.Number}");
            MySingleton s3 = MySingleton.Instance;
            Console.WriteLine($"s3 = {s3.Name} Num = {s3.Number}");
            if(s1 == s2 && s1 == s3)
            {
                Console.WriteLine($"All references pointing to same object!!");
            }
            Console.ReadKey();
        }
    }
}
