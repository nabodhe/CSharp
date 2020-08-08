using AbstractFactoryImpl.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryImpl
{
    public class ConcreteAutoEngine : IAutoEngine
    {
        public IgnitionType AutoEngineType { get ; set ; }
        public int CylinderCount { get ; set ; }
        public double HorsePower { get ; set ; }
        public string Description { get; set; }
        public override string ToString()
        {
            return $"AutoEngineType = {AutoEngineType} ; CylinderCount { CylinderCount} ; HorsePower { HorsePower } ; Description {Description}";
        }
    }
}
