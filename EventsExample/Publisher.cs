using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsExample
{
    public class Publisher
    {
        public delegate void Notify(string message);
        public event Notify BeginOutput;
        public event Notify EndOutput;

        public void Display(string message)
        {
            OnBeginOutput();
            Console.WriteLine(message);
            OnEndOutput();
        }

        private void OnBeginOutput()
        {
            if (BeginOutput != null)
                BeginOutput("starting output!");
        }

        private void OnEndOutput()
        {
            if (EndOutput != null)
                EndOutput("Ending output");
        }
    }
}
