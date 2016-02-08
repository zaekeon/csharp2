using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StringFormats
{
    class Program
    {
        static void Main(string[] args)
        {

            Ex2();  //call exercise method


            //numeric format specifiers

            //Raw text

            double num = 123456.789d;
            Console.WriteLine(num.ToString());  //outputs 12345.789

            //Rounding

            
            Console.WriteLine(num.ToString(".00")); //outputs 123456.79
            Console.WriteLine(num.ToString(".0")); //outputs 123456.8
            Console.WriteLine(num.ToString("0")); //outputs 1234567

            //Rounding with a Thousands Seperator
            Console.WriteLine(num.ToString("N2"));  //outputs 123,456.79


            //Displaying Local Currency
            Console.WriteLine(num.ToString("C")); //outputs $123,456.79

            //string length

            int letterCount = 0;
            const string FULL_NAME = "Bacon Jon Roberts";
            Console.WriteLine("Length of Original String: ");
            Console.WriteLine(FULL_NAME.Length);

            //output each characer of the string one at a time
            for (int i=0; i<FULL_NAME.Length; i++)
            {
                char letter = FULL_NAME[i];
                Console.Write(letter);
                letterCount += 1;
            }

            Console.WriteLine();
            Console.WriteLine("The letter count is: " + letterCount);

            //IndexOf

            string location = "Atlanta, Georgia";
            int first = location.IndexOf(",");  
            int second = location.IndexOf(",", first + 1);

            //LastIndexOf()

            int third = location.LastIndexOf(",");

            //substring

            location = "Location: Albany,Georgia,United States";
            const string SEARCH = ": ";
            int start = location.IndexOf(SEARCH);  //assigns 8
            int end = location.IndexOf(","); //assigns 16
            string city = location.Substring(start + SEARCH.Length, end - start - SEARCH.Length); //assigns 'Albany'
            Console.WriteLine(city);

            //Split()

            string storeLocation = "Retro Fitness,Secaucus,New Jersey";
            string[] location2 = storeLocation.Split(',');
            Console.WriteLine(location2[0]); //outputs 'retro fitness'

            Ex1();

            Console.ReadLine();

            //Join()

            string[] songInfo = { "Radio Nowhere", "magic Lyrics", "Bruce JOhnsoN", "3:19" };

            //creates "Radio nowhere,magiclyrics,brucejohnson,3:19"
            string delimitedString = String.Join(",", songInfo);
            Console.WriteLine(delimitedString);

            //StartsWith()

            string[] lastNames = { "Aglukkaq", "Jantzen" };
            foreach (string lastName in lastNames)
            {
                if (lastName.StartsWith("Agl"))
                {
                    Console.WriteLine(lastName);  //outputs "Aglukkaq
                }
            }

            foreach (string lastName in lastNames)
            {
                if (lastName.Contains("Ja"))
                {
                    Console.WriteLine(lastName); //outputs "Jantzen"
                }
            }

            //Trim()

            string name = "  White Space  ";
            Console.WriteLine(name.Length);
            Console.WriteLine(name.Trim().Length);


            //toUpper/ToLower

            Console.WriteLine(name.ToUpper());
            Console.WriteLine(name.ToLower());

            //Replace()

            string replace = "Retro Fitness,Secaucus,New Jersey";

            replace = replace.Replace("New Jersey", "NJ");


            //Insert()

            string townEvent = "Town Hall, November 12, 10:04 PM";
            int position = townEvent.IndexOf(",");
            //assigns 'Town Hall, Saturday November 12, 10:04 PM'
            townEvent = townEvent.Insert(position + 1, " Saturday");

            //Remove()

            string remove = "e) All of the above.";
            //assigns "All of the above."
            remove = remove.Remove(0, 3);


            //escape sequence
            /*

            \a bell alert
            \b backspace
            \f form feed
            \n newline
            \r carriage return
            \t horizontal tab
            \v vertical tab
            \' single quote
            \" double qoute
            \\ backslash
            \xhh
            \xhhhh
       

    */


            string escape = "c\\this\\is\\a\\path";



            //String literal

            string literal = @"c:\this\is\a\path";


            //regular expressions
            //using System.Text.RegularExpressions

            //  Starts With ^

            const string PATTERN = @"^Chapter";
            const string INPUT = "Chapter 10";
            Regex reg = new Regex(PATTERN);
            bool result = reg.IsMatch(INPUT);  //true


            //Ends With $

            const string PATTERN2 = @"Brazil$";
            const string INPUT2 = "San Paulo, Brazil";
            Regex reg2 = new Regex(PATTERN2);
            bool result2 = reg.IsMatch(INPUT2); //true

            // Or |

            const string PATTERN3 = @"Apples|Pears|Lemons";
            const string INPUT3 = "Red Apples";
            Regex reg3 = new Regex(PATTERN3);
            bool result3 = reg3.IsMatch(INPUT3); //true

            //using a match object
            Match bacon = reg3.Match(INPUT3);
            Console.WriteLine(bacon.ToString());

            const string PATTERN4 = "^Apples|Pears|Lemons$";
            ShowValidStatus(PATTERN4, "Red Apples");
            ShowValidStatus(PATTERN4, "Lemons and Grapes");
            ShowValidStatus(PATTERN4, "Apples");
            ShowValidStatus(PATTERN4, "Pears");
            ShowValidStatus(PATTERN4, "Lemons");

            //my attempt at first and last name validator...checks for capital letter at first name and last name with space in the middle.
            const string PATTERN5 = @"([A-Z]*)(\s[A-Z]*)";
            Regex reg4 = new Regex(PATTERN5);

            bool result4 = reg4.IsMatch("Joey Polarmo");
            Console.WriteLine("result4 value is: " + result4);

            //format conversions

            decimal decimalValue = Convert.ToDecimal("10.5");
            float floatValue = Convert.ToSingle("10.5");

            //etc

            int intValue;
            bool success = int.TryParse("hello", out intValue); //does not return an int

            success = float.TryParse("10.5", out floatValue);  //assigns floatValue to 10.5 since it will parse successfully.




            







        }

        public static bool ShowValidStatus(string pattern, string input)
        {
            Regex reg = new Regex(pattern);
            bool result = reg.IsMatch(input);

            if (result)
            {
                Console.WriteLine("PASS: " + pattern + " validates " + input);
            }
            else
            {
                Console.WriteLine("FAIL: " + pattern + " validates " + input);
            }

            return result;
        }



        private static void Ex1()
        {
            string user = "Name: Spencer Potter Balance: 3040.50";
            int firstNameIndex = user.IndexOf(":") + 2;
            int lastNameIndex = user.IndexOf(" ", firstNameIndex);
            int BalanceIndex = user.IndexOf(":",lastNameIndex) + 2;


            string firstName = user.Substring(firstNameIndex, lastNameIndex - firstNameIndex);
            Console.WriteLine(firstName);

            string lastName = user.Substring(lastNameIndex, BalanceIndex - lastNameIndex);

            Console.WriteLine(lastName);

            string balance = user.Substring(BalanceIndex);

            Console.WriteLine(balance);



        }

        private static void Ex2()
        {
            string fullName = "Eric Johnson";
            char lastLetter = fullName[fullName.Length - 1];
            Console.WriteLine("The value of lastLetter is: " + lastLetter);



            string testName = "Jeffrey steinberg";

            int indexOfLastName = testName.IndexOf(" ") + 1;

            string lastNameOfTestName = testName.Substring(indexOfLastName);

            Console.WriteLine("The last name is: " + lastNameOfTestName);


            //validates the test email address
            string pattern = @"([A-Za-z0-9]*)@([A-Za-z0-9]*)\.(com)";
            string email = "joey@joeyb.com";
            Regex regex1 = new Regex(pattern);

            Console.WriteLine(regex1.IsMatch(email));

            string pattern2 = @"(Cable)|(DSL)";

            Regex regex2 = new Regex(pattern2);
            string validateMe = "Cable";
            Console.WriteLine("validation is: " + regex2.IsMatch(validateMe));


        }
    }
}
