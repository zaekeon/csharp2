using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreLambda
{
    class Program
    {

        public delegate int Transformer(int i);

        static void Main(string[] args)
        {

            //lambda expression has the following form:

            //(parameters) => expresion-Or-statement-block

            //you can omit the first set of parenthesis if and only if there is 1 parameter of an inferable type.

            //the code can be a statement block as well...such as

            //x=>{ return x * x;};

            //lambda has access to outside variables
            //it uses the variable value that exists when the method is invoked, NOT when it was captured/declared.

            int factor = 2;
            Func<int, int> multiplier = n => n * factor;
            factor = 10;
            Console.WriteLine(multiplier(3));  //evaluates to 30

            //lambdas can update captured variables themselves...

            int seed = 0;
            Func<int> natural = () => seed++;
            Console.WriteLine(natural());  //0
            Console.WriteLine(natural());  //1
            Console.WriteLine(seed); //2


            Action[] actions = new Action[3];

            for (int i = 0; i < 3; i++)
                actions[i] = () => Console.Write(i);

            foreach (Action a in actions)  //outputs 333 because each action sees i at the time of invocation, not declaration.  the variable is treated as though it was declared outside the for loop.
            {
                a();

            }

            //if we wanted to avoid the above we would do something like below:

            Action[] actions2 = new Action[3];
            for (int x = 0; x < 3; x++)
            {
                int loopScopedx = x;
                actions[x] = () => Console.Write(loopScopedx);
            }

            foreach (Action a in actions2)
            {
                a();
            }

            //anonymous method

            //delegate delcaration at top

            Transformer sq = delegate (int x) { return x * x; };
            Console.WriteLine(sq(3));


        }
    }
}
