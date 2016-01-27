using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //allows your code to look within itself and inspect itself.

            //first thing is declare an assebly
            var assembly = Assembly.GetExecutingAssembly();  //this assembly...

            Console.WriteLine(assembly.FullName);

            var types = assembly.GetTypes();

            foreach (var type in types)
            {
                Console.WriteLine("Type: " + type.Name + " Basetype: " + type.BaseType);

                var props = type.GetProperties();
                foreach (var prop in props)
                {
                    Console.WriteLine("\tProperty: " + prop.Name + " Property Type: " + prop.PropertyType);
                }

                var fields = type.GetFields();
                foreach (var field in fields)
                {
                    Console.WriteLine("\tField: " + field.Name    );
                }

                var methods = type.GetMethods();
                foreach (var method in methods)
                {
                    Console.WriteLine("\tMethods: " + method.Name);
                }
            }

            var sample = new Sample { Name = "John", Age = 25 };

            var sampleType = typeof(Sample);
            //can do below too, but it's runtime operation.
            // var sampleType = sample.GetType();

            //get property name (it is case sensitive)
            var nameProperty = sampleType.GetProperty("Name");

            Console.WriteLine("Property: " + nameProperty.GetValue(sample));  //getting the name value property from the sample object

            var myMethod = sampleType.GetMethod("MyMethod");  //get the method of the sampletype object.

            myMethod.Invoke(sample, null);        //invoke the method, specifying the object and the parameters to pass.

            //use case:

            //get the type using the attributes
            var myTypes = assembly.GetTypes().Where(t => t.GetCustomAttributes<MyClassAttribute>().Count() > 0);  //get all types in my assembly where there are custom attributes assigned to the type

            //then you can loop through the types
            foreach (var type in myTypes)
            {
                Console.WriteLine(type.Name);

                //once you have the type you can get the method you want
                var methods = type.GetMethods().Where(m => m.GetCustomAttributes<MyMethodAttribute>().Count() > 0);

                foreach (var method in methods)
                {
                    Console.WriteLine(method.Name);
                }
            }
        }

    }
}
