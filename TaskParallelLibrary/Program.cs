using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskParallelLibrary
{
    class Program
    {
        static void Main(string[] args)
        {

            //these below are a way you can create and start a task...but there's another way below "TaskFactory"


            var t1 = new Task(() => DoSomeVeryImportantWork(1, 1500));
            t1.Start();

            var t2 = new Task(() => DoSomeVeryImportantWork(2, 3000));
            t2.Start();

            var t3 = new Task(() => DoSomeVeryImportantWork(3, 1000));
            t3.Start();

            //a task factory will create and start the task all in one step.
            var t4 = Task.Factory.StartNew(() => DoSomeVeryImportantWork(4, 500));

            //you can chain them together using the concept of the ContinueWith;
            //the lambda passes in the task that was returned...
     
            var t5 = Task.Factory.StartNew(() => DoSomeVeryImportantWork(5,5000)).ContinueWith((prevTask) => DoSomeOtherVeryImportantWork(5, 6000));

            //to make the program wait to display this message:
            var taskList = new List<Task> { t1, t2, t3, t4, t5 };
            Task.WaitAll(taskList.ToArray());


            //doing other work...
            for (var i = 0; i< 10; i++)
            {
                Console.WriteLine("Doing some other work...");
                Thread.Sleep(250);
                Console.WriteLine("i = {0}", i);
            }

            //looping through a list multihreaded...

            var intList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 234, 51, 3, 4, 5, 6, 123, 6, 7, 234, 6, 6723, 23, 434, 5, 623, 42, 3 };

            //you're passing the list to this method, and then the 2nd argument is the lamdba/method of what it's going to do on each of those inputs
            Parallel.ForEach(intList, (i) => Console.WriteLine(i));
            //notice parallel has a built-in wait...thread blocking...nothing beyond that line will happen until it's done.

            //allows you to pass in a range of values and do an action on
            Parallel.For(0, 100, (i) => Console.WriteLine(i));


            //what happens if i'm executing the tasks but i need to stop them because something has happened....
            //you do that with a cancelation token.

            var source = new CancellationTokenSource();  //pass token property in.
            try
            {
                
                
                var t6 = Task.Factory.StartNew(() => DoSomeVeryImportantWorkWithCancelToken(6, 1200,source.Token)).ContinueWith((prevTask) => DoSomeVeryImportantWorkWithCancelToken(6, 4000,source.Token));

                //this command cancels the request.
                source.Cancel();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType());
            }

            Console.WriteLine("Press any key to quit");


            Console.ReadKey();
        }

        static void DoSomeVeryImportantWork(int id, int sleepTime)
        {
            Console.WriteLine("Task {0} is starting", id);
            Thread.Sleep(sleepTime);
            Console.WriteLine("Task {0} has completed", id);
        }

        static void DoSomeOtherVeryImportantWork(int id, int sleepTime)
        {
            Console.WriteLine("Task {0} is starting more work", id);
            Thread.Sleep(sleepTime);
            Console.WriteLine("Task {0} has completed more work", id);
        }

        static void DoSomeVeryImportantWorkWithCancelToken(int id, int sleepTime,CancellationToken token)
        {
            //check if work has been canceled
            if (token.IsCancellationRequested)
            {
                Console.WriteLine("Cancellation requested");
                token.ThrowIfCancellationRequested();
            }

            Console.WriteLine("Task {0} is starting", id);
            Thread.Sleep(sleepTime);
            Console.WriteLine("Task {0} has completed", id);
        }


    }
}
