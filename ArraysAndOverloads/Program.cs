using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndOverloads
{
    class Program
    {
        static void Main(string[] args)
        {

            ArraysExample();

            //these demonstrate the differences when using polymorphism between new keyword and override 
            ABase baseclass = new ABase();
            AChild achild = new AChild();
            AChild2 achild2 = new AChild2();
            ABase achild3 = new AChild();
            ABase achild4 = new AChild2();

            Console.WriteLine("\n\n baseclass object");
            baseclass.PrintMethod();

            Console.WriteLine("\n\n achild object");
            achild.PrintMethod();

            Console.WriteLine("\n\n achild2 object");
            achild2.PrintMethod();

            Console.WriteLine("\n\n achild3 object");
            achild3.PrintMethod();

            Console.WriteLine("\n\n achild4 object");
            achild4.PrintMethod();

            List<ABase> theList = new List<ABase> { baseclass, achild, achild2,achild3,achild4 };

            foreach (var item in theList)
            {
               
                item.PrintMethod();
            }
        }

        public static void ArraysExample()
        {
            int[] array1 = { 1, 2, 3, 4, 5 };

            //array1
            Console.WriteLine("This is array 1");
            foreach (var item in array1)
            {
                Console.WriteLine(item);
            }


            //method 1
            int[,]array2 = { { 1, 2, }, { 3, 4 } };

            // {1,2}
            // {3,4}
            //
            //

            Console.WriteLine("Element 1 is " + array2[1,0]);
        }
    }
}
