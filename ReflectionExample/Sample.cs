using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionExample
{
    [MyClass]
    public class Sample
    {
        public string Name { get; set; }
        public int Age;

        [MyMethod]
        public void MyMethod()
        {
            Console.WriteLine("Hello from MyMethod!");
        }

        public void NoAttributeMethod()
        {

        }
    }
}
