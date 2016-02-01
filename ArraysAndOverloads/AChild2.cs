using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndOverloads
{
    class AChild2 : ABase
    {

        public new void PrintMethod()
        {
            Console.WriteLine("This is a new method from AChild2" + this.ToString());
        }
    }
}
