using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//includes
//install the nuget package for jSON.net or manually download the assembly and add a reference.
using System.IO;
using Newtonsoft.Json;

namespace JSONNETExample
{

    class Person
    {
        public string name { get; set; }
        public int age { get; set; }

        public override string ToString()
        {
            return string.Format("Name: {0} \nAge: {1}", name, age);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //deserialize json directly from file

            string JSONstring = File.ReadAllText("JSON.json");
            Person p1 = JsonConvert.DeserializeObject<Person>(JSONstring);
            Console.WriteLine(p1);

            //output file

            Person p2 = new Person { name = "ben", age = 46 };
            string outputJSON = JsonConvert.SerializeObject(p2);
            File.WriteAllText("Output.json", outputJSON);

        }
    }
}
