using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreInterfaces
{
    class Employee : IPerson
    {
        public string FirstName
        {
            get;
            private set;
        }

        public string LastName
        {
            get;

            set;
        }

        public DateTime HireDate { get; set; }

        public Employee(string firstName, string lastName, DateTime hireDate)
        {
            FirstName = firstName;
            LastName = lastName;
            HireDate = hireDate;
        }

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }

        public void ShowHireDate()
        {
            Console.WriteLine(HireDate.ToLongDateString());
        }
    }
}
