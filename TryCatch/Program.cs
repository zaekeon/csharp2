using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 5;
            int i2;

            try
            {
                i2 = i / 0;
            }
            catch (Exception e)
            {
                Console.WriteLine("You tried to divide by zero");
            }


            try
            {
                i2 = i / 0;
            }
            catch(Exception e) when (i < 10)   //this is an exception filter.  They can also be side affecting such as a log or something.
            {
                Console.WriteLine("You tried to divide by zero and I detected that i is less than 10");
            }
            catch (Exception e)
            {
                Console.WriteLine("You tried to divide by zero");
            }
            finally
            {
                Console.WriteLine("This is the finally block.  it should always be ran");
            }


            try {
                UsingStatement();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("An error occured accessing the file");
                Console.WriteLine(e.FileName);
            }

        }

        public static void UsingStatement()
        {
            //remember using statements get rid of stuff automatically when using unmanaged resources.

            using (StreamReader reader = File.OpenText("file.txt"))
            {
                Console.WriteLine("Some work...");
            }
        }


    }
}
