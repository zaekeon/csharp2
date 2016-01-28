using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{

    [Sample(Name = "John", Version = 1)]
    class Test
    {
        [Sample]
        public int MyProperty { get; set; }
        [Sample]
        public void Method() { }

    }
}
