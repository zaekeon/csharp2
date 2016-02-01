using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndOverloads
{
    class AChild : ABase
    {

        public override void PrintMethod()
        {

            Console.WriteLine("This is an overridden method from achild" + this.ToString());
        }

    }
}
