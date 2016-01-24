using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        
        static void Main(string[] args)
        {

            //GenericList<string> cheese = new GenericList<string>();

            //cheese.Add("bacon");

            //Console.WriteLine( cheese[0]);

            //GenericDictionary<string, int> bacon = new GenericDictionary<string, int>();

            //nullable class is part of .net System.Nullable
            var number = new Nullable<int>();
            Console.WriteLine(number.HasValue);
            Console.WriteLine(number.GetValueOrDefault());
         
        }
    }
}
