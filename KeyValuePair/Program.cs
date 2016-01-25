using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyValuePair
{
    class Program
    {
        static void Main(string[] args)
        {
            KeyValuePair<int, string> keyPair = new KeyValuePair<int, string>(1, "apple");

            Console.WriteLine(keyPair.Key + " " + keyPair.Value);

        }
    }
}
