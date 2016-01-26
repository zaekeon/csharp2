using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsExample
{
    class Program
    {

        public delegate void MyEvent (string message);
        public event MyEvent myEvent;

        static void Main(string[] args)
        {
            //Program.MyEvent.myEvent += message => Console.WriteLine(message);

            Publisher publisher = new Publisher();

            //subscribe to events and set method reference

            publisher.BeginOutput += StartOutputCallback;
            publisher.EndOutput += EndOutputCallback;
            publisher.Display("I am a subscriber");

            //dereference callback methods

            publisher.BeginOutput -= StartOutputCallback;
            publisher.EndOutput -= EndOutputCallback;

            //output text when not subscribed to the event
            publisher.Display("\nI am not a subscriber");
            Console.ReadLine();

            

        }

        public static void StartOutputCallback(string message)
        {
            Console.WriteLine("StartOutputCallback - " + message);
        }

        public static void EndOutputCallback(string message)
        {
            Console.WriteLine("EndOutputCallback - " + message);

        }
    }
}
