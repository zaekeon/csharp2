using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic
{
    class Program
    {
        static void Main(string[] args)
        {

            //type resolution is done at:
            //static language - compile time - c#/java

            //dynamic language - runtime ruby/javascript/python

            //reflection is away to inspect metadata of object.

            object obj = "Mosh";
            obj.GetHashCode();

            var methodInfo = obj.GetType().GetMethod("GetHashCode");
            methodInfo.Invoke(null, null);
     


           dynamic excelObject = "mosh";  //dynamic well you get around that issue. Otherwise the below wouldn't work bc that method doens't exist.

            excelObject.Optimize();


            dynamic name = "Mosh";
            name = 10;

            //dynamic types you can do wahtever you want with them.

            var bacon = name;


        }
    }
}
