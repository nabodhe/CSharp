using AbstractFactoryImpl.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryImpl
{
    public class Truck : IVehicle
    {

        public IAutoBody GetVehicleBody(BodyType bodyType)
        {
            IAutoBody body = null;
            if (BodyType.Truck == bodyType)
            {
                body = new ConcreteAutoBody() { AutoBodyType = bodyType, HasSterio = true, NoOfDoors = 2, Description = "Truck is Made" };
            }
            else
            {
                body = new ConcreteAutoBody() { AutoBodyType = BodyType.None, HasSterio = false, NoOfDoors = 0, Description = "No Vehicle is Made" };
            }
            return body;
        }

        public IAutoEngine GetVehicleEngine(IAutoBody vehicleBody, IgnitionType ignitionType)
        {
            IAutoEngine engine = new ConcreteAutoEngine() { AutoEngineType = ignitionType, CylinderCount = 4, HorsePower = 100 };
            if (vehicleBody != null && vehicleBody.AutoBodyType == BodyType.Truck)
            {
                engine.Description = "Truck Engine created.";
            }
            else
            {
                engine.Description = $"No Engine created as body type is {(vehicleBody == null ? BodyType.None : vehicleBody.AutoBodyType)}.";
            }
            return engine;
        }

        public string ToString(IAutoBody body, IAutoEngine engine)
        {
            return $" AutoBody { body?.ToString() } , AutoEngine { engine?.ToString() } ";
        }
    }
}
