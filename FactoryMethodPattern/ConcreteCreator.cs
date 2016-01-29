using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    class ConcreteCreator : Creator
    {
        public override void AnOperation()
        {
            Console.WriteLine("An operation");
        }

        public override Product FactoryMethodPattern()
        {
            return new ConcreteProduct();
        }
    }
}
