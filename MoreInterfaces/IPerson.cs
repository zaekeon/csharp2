using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreInterfaces
{
    interface IPerson
    {
        string LastName { get; }
        string FirstName { get; }

        DateTime HireDate { set; }
        string GetFullName();

        void ShowHireDate();


    }
}
