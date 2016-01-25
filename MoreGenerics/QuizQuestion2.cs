using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreGenerics
{
    public class QuizQuestion2<T, U, V>
    {
        T ResponseA;
        U ResponseB;
        V ResponseC;
        private string Question { get; set; }

        public QuizQuestion2(string question, T a, U b, V c)
        {
            Question = question;
            ResponseA = a;
            ResponseB = b;
            ResponseC = c;

        }

        public void ShowTypes()
        {
            Console.WriteLine("The instance type is: ");
            Console.WriteLine(typeof(T).ToString());
            Console.WriteLine(typeof(U).ToString());
            Console.WriteLine(typeof(V).ToString());

        }

        public void ShowQandA()
        {
            Console.WriteLine("Question: " + Question);
            Console.WriteLine("Answer:  " + ResponseA.ToString() + "\n");
            Console.WriteLine("Answer:  " + ResponseB.ToString() + "\n");
            Console.WriteLine("Answer:  " + ResponseC.ToString() + "\n");
        }
    }
}
