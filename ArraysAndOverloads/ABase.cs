using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndOverloads
{
    class ABase
    {

        public virtual void PrintMethod()
        {
            Console.WriteLine("This is from the base class" + this.ToString());
        }
    }
}
