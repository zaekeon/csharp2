using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreInterfaces
{
    class Inspection<T> : IInspection<T>
    {
        public DateTime Time { get; set; }
        public List<T> Items { get; set; }

        public Inspection()

        {
            Time = DateTime.Now;
            Items = new List<T>();
        }
    }
}
