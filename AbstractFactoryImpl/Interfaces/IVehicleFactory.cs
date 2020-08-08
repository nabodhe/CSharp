using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryImpl.Interfaces
{
    public interface IVehicleFactory
    {
        IVehicle VehicleObject { get; }
        IVehicle GetVehicle(string type);
        string ToString();
    }
}
