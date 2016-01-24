using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASyncProgramming
{
    class Program
    {
        static void Main(string[] args)
        {

            //sync
            //everything is executed one by line one at a time.
            //when a function is called, program must wait until the function has returned.

            //in async
            //program execution continues to the next line without waiting for the function to complete.

            //async function calls a callback when it's done.

            //realworld examples
            //windows media player
            //web browser

            //when to use async?

            //when we have a blocking opreation
            //accessing web
            //working with files /database
            //working with images

            //traditional approach
            //multithreading & callbacks

            //new in 4.5
            //async / await - task based async model.



        }
    }
}
