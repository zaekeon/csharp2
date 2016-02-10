using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace OOTO_Tracker
{
    public static class OOTOWriter
    {

        public static bool SavePerson(Person person, string path)
        {

            string output = JsonConvert.SerializeObject(person);

            if (person == null)
            {
                return false;
            }

            File.WriteAllText(path, output);


            return true;
        }

     
    }
}
