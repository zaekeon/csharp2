using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    class ConcreteProduct : Product
    {
        public override void TestClass()
        {
            Console.WriteLine("data from the concrete class");
        }
    }
}
