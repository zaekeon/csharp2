using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HashtableExample
{
    class Program
    {
        static void Main(string[] args)
        {

            //hashtable similar to dictionary but it can store keyvalue objects of varying types.

            Hashtable grades = new Hashtable();
            grades.Add("C#", "A");
            grades.Add("Java", 74.0f);
            grades.Add("ASP.NET", "A");
            DisplayAllValues(grades);

            if (grades.ContainsKey("C")) //check for object by key
                Console.WriteLine("A C# Course Exists");
            if (grades.ContainsValue(74.0f))  //check for object by value
                Console.WriteLine("A course has a grade that is 74.0f");
            grades.Remove("Java"); //remove object by key
            if (!grades.Contains("Java"))
                Console.WriteLine("The Java course no longer exists");
            grades.Clear();
            DisplayAllValues(grades);
            Console.ReadLine();

        }

        public static void DisplayAllValues(Hashtable table)
        {
            foreach   (DictionaryEntry item in table)
            {
                if (item.Key.GetType() == typeof(String))
                {
                    //if value is letter grade show it
                    if (item.Value.GetType() == typeof(string))
                        ShowGrade((string)item.Key, (string)item.Value);
                    //if value is a float convert if to a letter grade
                    else if (item.Value.GetType() == typeof(float))
                    {
                        float grade = (float)item.Value;
                        string letterGrade = "F";
                        if (grade >= 80.0f)
                            letterGrade = "A";
                        else if (grade >= 70.0f)
                            letterGrade = "B";
                        ShowGrade((string)item.Key, letterGrade);

                    }
                }
            }
        }

        public static void ShowGrade(string course, string grade)
        {
            Console.WriteLine(course + " " + grade);
        }
    }
}
