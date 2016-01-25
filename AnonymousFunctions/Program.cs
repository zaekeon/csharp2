using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousFunctions
{
    class Program
    {

        delegate float Average(int x, int y);
        static void Main(string[] args)
        {

            Helper.CheeseHelper cow = (string ovx, int y) => { Console.WriteLine(ovx + y); };

            cow("onion", 5);

            //delcare anonymous functin reference
            Average average;

            average = (int x, int y) =>
            {
                float z;
                z = (x + y) / 2.0f;
                return z;
            };

            //invoke anonymous function
            Console.WriteLine(average(9, 2).ToString("N1"));

            //reassign the body of the anonymous function.
            average = (x, y) => (x + y) / 2.0f;

            //invoke the anonymous function with the simplieified body
            Console.WriteLine(average(9,2).ToString("N1"));

            Console.ReadLine();





        }
    }
}
