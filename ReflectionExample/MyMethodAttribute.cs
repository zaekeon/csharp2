using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionExample
{
    [AttributeUsage(AttributeTargets.Method)]
    public class MyMethodAttribute : Attribute
    {
    }
}
