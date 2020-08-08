using AbstractFactoryImpl.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace AbstractFactoryImpl
{
    public abstract class VehicleFactory : IVehicleFactory
    {
        public abstract IVehicle GetVehicle(string vehicleType);

        public IVehicle VehicleObject { get; private set; }
        public IAutoBody AutoBody { get; private set; }
        public IAutoEngine EngineType { get; private set; }

        protected void SetBodyEngineObject(IVehicle vehicleObj, string vehicleType)
        {
            IgnitionType eIgnitionType = IgnitionType.None;
            Enum.TryParse(vehicleType, out eIgnitionType);
            var bodyObj = vehicleObj.GetVehicleBody(BodyType.None);
            var engineType = vehicleObj.GetVehicleEngine(bodyObj, eIgnitionType);
            VehicleObject = vehicleObj;
            AutoBody = bodyObj;
            EngineType = engineType;
        }

        public new string ToString()
        {
            return VehicleObject.ToString(AutoBody, EngineType);
        }
    }

    public class ConcreteDefaultVehicleFactory : VehicleFactory
    {

        public override IVehicle GetVehicle(string vehicleType)
        {
            IVehicle vehicleObj = new Locomotive();
            SetBodyEngineObject(vehicleObj, vehicleType);
            return vehicleObj;
        }
    }

    public class ConcreteCarVehicleFactory : VehicleFactory
    {
        public override IVehicle GetVehicle(string vehicleType)
        {
            IVehicle vehicleObj = new Locomotive();
            SetBodyEngineObject(vehicleObj, vehicleType);
            return vehicleObj;
        }
    }

    public class ConcreteTruckVehicleFactory : VehicleFactory
    {
        public override IVehicle GetVehicle(string vehicleType)
        {
            IVehicle vehicleObj = new Truck();
            SetBodyEngineObject(vehicleObj, vehicleType);
            return vehicleObj;
        }
    }
}
