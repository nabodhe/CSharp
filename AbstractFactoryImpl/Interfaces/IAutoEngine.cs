using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryImpl.Interfaces
{
    public interface IAutoEngine
    {
        IgnitionType AutoEngineType { get; set; }
        int CylinderCount { get; set; }
        double HorsePower { get; set; }
        string Description { get; set; }
        string ToString();
    }
}
