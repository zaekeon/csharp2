using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<char, string> certifications = new Dictionary<char, string>();
            certifications.Add('P', "Passenger transport");
            certifications.Add('H', "Hazardous materials");
            certifications.Add('N', "Tank vehicles (liquids in bulk)");
            certifications.Add('T', "Double/Triple trailers");

            ShowCertifications(certifications);

            //search for certfications by key and confirm

            if (certifications.ContainsKey('P'))
                Console.WriteLine("Has certfication 'P'");

            //check certification for a specific value and confirm
            if (certifications.ContainsValue("Double/Triple trailers"))
                Console.WriteLine("Has certification 'T'");

            //remove certification 'T' by key.
            certifications.Remove('T');
            if (!certifications.ContainsValue("Double/Triple trailers"))
                Console.WriteLine("No longer has certification 'T'");

            //remove all certifications
            certifications.Clear();
            if (certifications.Count == 0)
                Console.WriteLine("All certifications removed");
            Console.ReadLine();
        
        }

        public static void ShowCertifications(Dictionary<char,string> certs)
        {
    foreach (KeyValuePair<char, string> cert in certs)
            {
                Console.WriteLine("Key:  " + cert.Key + " Value: " + cert.Value);
                Console.WriteLine();
            }
        }
    }
}
