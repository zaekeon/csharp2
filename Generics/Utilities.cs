using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Utilities
    {
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }


        //created a generic method here.

       //Since we thought that it was an object and didn't have any methods on the input we made the T (type) implement the IComparable interface to get access
       //to those methods.

            //then below we delcare public T (because T is the return type) and then Max<t> (to make it generic) and then specifiy the types in the params.
            //you could also move the "where T : IComparable to the class level and then you wouldn't have to specify it with the method.
        public T Max<T>(T a, T b) where T : IComparable
        {
            return a.CompareTo(b) > 0 ? a : b;
        }

        public void DoSomething<T>(T value) where T : IComparable,new()
        {
            var obj = new T();
        }
        //other constraints

        //where T : IComparable
        //where T : Product     - check if it's a type of object or any of it's children
        //where T : struct (is it a value type?)
        //where T : class (is it a reference type?)
        //where T : new() - object that has a default constructor

        //you can have multiple constraints by seperating them with a comma.



    }
}
