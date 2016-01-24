using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTest
{
    class Program
    {
        static void Main(string[] args)
        {

            

           
            Action<string> actionHandler = new Action<string>(WriteOut);

            actionHandler("BACON FARTS AND ICE CREAM");

            MyClass testObject = new MyClass();
            MyClass.DoSomethingHandler myevent =  new MyClass.DoSomethingHandler(testObject.DoSomething);

            string mainMessage = "What did you do?";

            myevent(mainMessage);
            DisplayDelegateInfo(myevent);

            Console.WriteLine("Now adding another method to the delegate..");

            myevent += WriteOut;

            DisplayDelegateInfo(myevent);

            Car c1 = new Car("SlugBug", 100, 10);

            c1.RegisterWithCarEngine(new Car.CarEngineHandler(OnCarEngineEvent));

            Console.WriteLine("*********Speeding up *****");
            for (int i = 0; i < 6; i++)
            {
                c1.Accelerate(20);
                Console.ReadLine();
            }
        }

        public static void OnCarEngineEvent(string msg)
        {
            Console.WriteLine("\n***** Message from Car Object *****");
            Console.WriteLine("=> {0}", msg);
            Console.WriteLine("****************************************\n");
        }

        public static void DisplayDelegateInfo(Delegate delObj)
        {
            foreach(Delegate d in delObj.GetInvocationList())
            {
                Console.WriteLine("Method Name: {0}", d.Method);
                Console.WriteLine("Type Name: {0}", d.Target);
            }
        }

        public static void WriteOut(string message)
        {
            Console.WriteLine("2nd Event: " + message);
        }
    }
}
