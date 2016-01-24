using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //valuetype cannot be null.

            // DateTime date = null;  - error, it can't be set to null.

            Nullable<DateTime> date = null;   //nullable is a generic structure.

            // or a shortcut is 

            DateTime? date2 = null;

            Console.WriteLine(date.GetValueOrDefault());  //preferred way of gettng the value

            Console.WriteLine(date.HasValue);  //test if it has a value

            Console.WriteLine(date.Value);  //you'll get ane rror if this is null and you try to use it.

            DateTime date3 = new DateTime(2014, 1, 1);
            //DateTime date4 = date3;  //this is invalid. It can't work unless you use the getvalueordefaultmethod to assign it.


            DateTime? date5 = null;
            DateTime date6;

            if (date5 != null)
                date6 = date5.GetValueOrDefault();
            else
                date6 = DateTime.Today;

            //you can rewrite the above code like this:

            date6 = date5 ?? DateTime.Today;  // the ?? is the null coelscing operator.  //if date has a value assign her otherwise assign right.



        }
    }
}
