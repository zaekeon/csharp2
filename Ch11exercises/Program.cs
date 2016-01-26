using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch11exercises
{
    class Program
    {
        public delegate string  methodHandler(float input);
        static void Main(string[] args)
        {

            //traditional way 
            methodHandler bacon;
            bacon = new methodHandler(CallMethod);

            float testValue = 2.042f;

            string cheese = bacon(testValue);

            Console.WriteLine(cheese);

            //now an anonymous method

            methodHandler bacon2 = x => x.ToString("N2");

            string cheese2 = bacon2(3.042f);

            Console.WriteLine(cheese2);

            //using func<T>

            Func<float, string> cow = x => x.ToString("N2");


            string onion = cow(345.23f);

            Console.WriteLine(onion);


        }

        public static string CallMethod (float input)
            {
           string value = input.ToString("N2");
            return value;
    }

    }
}
