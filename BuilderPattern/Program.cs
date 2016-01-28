using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Program
    {

        //good choice when

            //seperate construction of complex object from it's representation so you can use the same construction process for diff types of objects

            //or

            //parse a complex representation and create one of several target objects out of it.


        static void Main(string[] args)
        {
            //director 
            //builder
            //concrete builder
            //product class   

            MenuDirector director = new MenuDirector();

            MenuBuilder builder1 = new BurgerMenuBuilder();
            director.Contruct(builder1);
            Menu menu1 = builder1.GetResult();
            Console.WriteLine("Burger menu {0}", menu1);

        }
    }
}
