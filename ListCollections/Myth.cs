using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListCollections
{
    public class Myth
    {
        public string GreekName { get; private set; }
        public string RomanName { get; private set; }

        public Myth(string greekName, string romanName)
        {
            GreekName = greekName;
            RomanName = romanName;
        }
    }
}
