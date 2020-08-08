using AbstractFactoryImpl.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryImpl.Common
{
    public static class AutoMBuilder
    {
        public static IVehicleFactory Build(BodyType bodyType)
        {
            IVehicleFactory factory=null;
            if (bodyType == BodyType.Car)
            {
                factory = new ConcreteCarVehicleFactory();
            }
            else if(bodyType == BodyType.Truck)
            {
                factory = new ConcreteTruckVehicleFactory();
            }
            else
            {
                factory = new ConcreteDefaultVehicleFactory();
            }
            return factory;
        }
    }
}
