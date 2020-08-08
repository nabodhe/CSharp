using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryImpl.Interfaces
{
    public interface IVehicle
    {
        IAutoBody GetVehicleBody(BodyType bodyTpe);
        IAutoEngine GetVehicleEngine(IAutoBody vehicleBody,IgnitionType ignitionType);
        string ToString(IAutoBody body,IAutoEngine engine);
    }
}
