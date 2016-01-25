using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreGenerics
{
    public class QuizQuestion<T> 
    {
        public T Answer { get; private set; }

        
        private string Question { get; set; }

        public QuizQuestion(string question, T answer)
        {
            Question = question;
            Answer = answer;

        }

        public void ShowType()
        {
            Console.WriteLine("The instance type is: ");
            Console.WriteLine(typeof(T).ToString());

        }

        public void ShowQandA()
        {
            Console.WriteLine("Question: " + Question);
            Console.WriteLine("Answer:  " + Answer.ToString() + "\n");
        }
    }
}
