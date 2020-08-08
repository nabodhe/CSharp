using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryImpl.Interfaces
{
    public interface IAutoAssembly
    {
        IAutoBody AutoBodyPart { get; protected set; }
        IAutoEngine AutoEnginePart { get; protected set; }
    }
}
