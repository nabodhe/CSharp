using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonImpl
{
    public sealed class MySingleton
    {
        static readonly Lazy<MySingleton> MySingletonObj = new Lazy<MySingleton>(() => new MySingleton());

        public static MySingleton Instance
        {
            get
            {
                return MySingletonObj.Value;
            }
        }

        public string Name { get; private set; }
        public int Number { get; private set; }
        private MySingleton()
        {
            Number = new Random(50).Next(1, 50);
            Name = " One ";
        }
    }
}
