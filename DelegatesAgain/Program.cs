using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAgain
{
    public class Program
    {
        static void Main(string[] args)
        {
            Output.Writer writer = new Output.Writer(Display);
            writer("hello");
            Console.ReadLine();

            writer += Display2;

            writer("hello again");
        }

        static void Display(string output)
        {
            Console.WriteLine(output);
        }

        static void Display2(string output)
        {
            Console.WriteLine("This is a 2nd method!! " + output);
        }
    }

    public class Output
    {
        public delegate void Writer(string output);
    }
}
