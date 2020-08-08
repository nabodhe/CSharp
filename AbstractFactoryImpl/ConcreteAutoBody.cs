using AbstractFactoryImpl.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryImpl
{
    class ConcreteAutoBody : IAutoBody
    {
        public BodyType AutoBodyType { get; set; }
        public bool HasSterio { get; set; }
        public int NoOfDoors { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return $"AutoBody = {AutoBodyType} ; HasSterio { HasSterio} ; NoOfDoors { NoOfDoors } ; Description {Description}";
        }
    }
}
