using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Method)]
    public class SampleAttribute : Attribute
    {
        //purpose is to assign metadata to code you've written.
        public string Name { get; set; }
        public int Version { get; set; }
    }
}
