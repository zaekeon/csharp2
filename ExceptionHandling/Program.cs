using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {

            //there's a cleaner way to write this code...using the 'using' keyword.
            
            //exceptions should be from most specific to most generic..
            StreamReader stream = null;  //have to initialize it to null or you can't use it in the try block...
            try
            {
                Calculator calc = new Calculator();
                calc.Divide(5, 0);
               stream  = new StreamReader(@"c:\file.zip");
                var content = stream.ReadToEnd();
            }

            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (ArithmeticException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (Exception ex)
            {

                Console.WriteLine("Sorry an error occured");
               // throw;  //throw can send the error to the caller of the code.
            }
            finally  //finally will run.
            {
                //unmanaged resources need to implement IDisposable interface.
                Console.WriteLine("The bacon flows from within");
                if (stream != null)
                stream.Dispose();
            }





        }
    }
}
