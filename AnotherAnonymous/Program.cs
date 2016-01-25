using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotherAnonymous
{
    class Program
    {
        public delegate void ShowOutput(string message);
        static void Main(string[] args)
        {
            ShowOutput showOutput;

            //the intput type can be inferred.
            showOutput = input => Console.WriteLine(input);

            showOutput("hello");

            //an example using func<>.  Using Func<> we don't need to delcare a delegate.  We can use this generic instance.

            Func<int, int, float> average2;

            average2 = (x,y) => (x + 7) / 2.0f;

            Console.WriteLine(average2(1,5).ToString("N"));
            Console.ReadLine();


        }
    }
}
