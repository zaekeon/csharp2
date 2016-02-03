using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumExample
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Cow.Milk);
            Func<int,int> cheese = x => x + 1;
            int cowFiber = cheese(4);

            
        }
    }
}
