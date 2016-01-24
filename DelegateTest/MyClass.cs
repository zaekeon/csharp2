using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTest
{
    public class MyClass
    {

        public delegate void DoSomethingHandler(string message);
        public void DoSomething(string message)
        {
            Console.WriteLine(message);
        }
    }
}
