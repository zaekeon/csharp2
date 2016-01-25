using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            QuizQuestion<int> questionA = new QuizQuestion<int>("How many teeth do sharks use in a lifetime?", 30000);
            questionA.ShowType();
            questionA.ShowQandA();

            QuizQuestion<string> questionB = new QuizQuestion<string>("What type of shark swims fastest?", "The short fin mako shark");
            questionB.ShowType();
            questionB.ShowQandA();

            Console.ReadLine();


            QuizQuestion2<int, string, string> question2 = new QuizQuestion2<int, string,string>("Approximately how many shark species exist?", 350, "None of the above", "Cow MIlk");

            question2.ShowTypes();
            question2.ShowQandA();
            Console.ReadLine();
        }
    }
}
