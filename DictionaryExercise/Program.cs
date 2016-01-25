using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> catalog = new Dictionary<int, string>();

            catalog.Add(4, "The Best Bacon Book");
            catalog.Add(6, "The worst bacon book");

            foreach (KeyValuePair<int,string> item in catalog)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }

        }
    }
}
