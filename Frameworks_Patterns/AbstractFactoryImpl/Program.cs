using AbstractFactoryImpl.Common;
using AbstractFactoryImpl.Interfaces;
using System;
using static System.Console;

namespace AbstractFactoryImpl
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IVehicleFactory factory = null;
            CreateAndDisplayCar(ref factory);
            CreateAndDisplayTruck(ref factory);
            ReadKey();

        }

        private static void CreateAndDisplayCar(ref IVehicleFactory factory)
        {
            factory = AutoMBuilder.Build(BodyType.Car);

            IVehicle vehicle = factory.GetVehicle(IgnitionType.Automatic.ToString());
            WriteLine($" Vehicle {factory.ToString()}");

            vehicle = factory.GetVehicle(IgnitionType.Hybrid.ToString());
            WriteLine($" Vehicle {factory.ToString()}");

            vehicle = factory.GetVehicle(IgnitionType.None.ToString());
            WriteLine($" Vehicle {factory.ToString()}");

            ReadKey();
        }

        private static void CreateAndDisplayTruck(ref IVehicleFactory factory)
        {
            factory = AutoMBuilder.Build(BodyType.Truck);

            IVehicle vehicle = factory.GetVehicle(IgnitionType.Automatic.ToString());
            WriteLine($" Vehicle {vehicle.ToString()}");

            vehicle = factory.GetVehicle(IgnitionType.Manual.ToString());
            WriteLine($" Vehicle {vehicle.ToString()}");

            vehicle = factory.GetVehicle(IgnitionType.None.ToString());
            WriteLine($" Vehicle {vehicle.ToString()}");

            ReadKey();
        }
    }
}
