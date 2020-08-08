using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryImpl.Interfaces
{
    public interface IAutoBody
    {
        BodyType AutoBodyType { get; set;}
        bool HasSterio { get; set; }
        int NoOfDoors { get; set; }
        string Description { get; set; }
        string ToString();
    }
}
