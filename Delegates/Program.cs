using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            //a delegate is an object that knows how to call a method (or a group of methods)
            //simply -- a delegate is a reference to a method/function(s)

            //why?
            //For designing extensible and flexible applications (eg frameworks often used here)

            //multicast delegate lets us have multiple function pointers.
            //delegate is just one.

            PhotoProcessor proc = new PhotoProcessor();

            //interface vs delegate
            //some is personal taste
            //delegates event design pattern, caller doesn't need to access properties

            //if photoprocessor needed to access other properties or methods a delegate wouldn't work.


            //so what we've done here is we created an instance of the photofilters object so we could reference it's methods.
            //we created an instance of the delegate and then assigned the method from photofilters to it.
            PhotoFilters photofilters = new PhotoFilters();
            PhotoProcessor.PhotoFilterHandler filterHandler = photofilters.ApplyBrightness;

            //adding more points/methods
            filterHandler += photofilters.ApplyContrast;
            filterHandler += photofilters.Resize;
            filterHandler += Program.RemoveRedeye;
            proc.Process("path here", filterHandler);

            //when passing the reference to the delegate you don't need the () because you're not passing anything or calling the method.
            Action<Photo> filterHandler2 = photofilters.ApplyBrightness;
            filterHandler2 += RemoveRedeye;

            proc.SuperProces("photopath", filterHandler2);


        }

        //i could also create my own filter and add it to the delegate

        public static void RemoveRedeye(Photo photo)
        {
            Console.WriteLine("removing redeye");
        }
    }
}
