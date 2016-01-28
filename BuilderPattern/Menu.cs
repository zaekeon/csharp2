using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Menu
    {

        private Dictionary<string, string> _parts = new Dictionary<string, string>();

        public void Add(string part)
        {
            _parts.Add(part, part);
        }

        public override string ToString()
        {
           
                return String.Join(", ", _parts.Values);
            
        }
    }
}
