using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee employee = new Employee("Treele", "Grumbus", DateTime.Now);
            Console.Write("Full Name:");
            Console.WriteLine(employee.GetFullName());
            Console.WriteLine("Hire Date:");
            employee.ShowHireDate();

            //explicit interface example
            Parcel parcel = new Parcel();
            IJapan toJapan = (IJapan)parcel;
            IMexico toMexico = (IMexico)parcel;

            const decimal WEIGHT = 3.89m;

            Console.WriteLine("Mailing to Mexico costs " + toMexico.Cost(WEIGHT).ToString("C")) ;
            Console.WriteLine("Mailing to Japan costs " + toJapan.Cost(WEIGHT).ToString("C"));

            Inspection<float> airTest = new Inspection<float>();
            airTest.Items.Add(290.0f);
            airTest.Items.Add(287.0f);

            Console.WriteLine("Sample Date: " + airTest.Time.ToString("m"));

            foreach (float sample in airTest.Items)
            {
                Console.WriteLine(sample + " parts per million.");
            }
            Console.ReadLine();
        }
    }
}
