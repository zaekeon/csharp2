using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch11ex5
{
    public class Input
    {
        public delegate void UserInputDel(string input);

        public event UserInputDel UserInput;
        public void GetUserInput()
        {
            UserInput += UserInputEventHandler;

            while (true)
            {
                Console.WriteLine("Type any characters or 'q' to quit and press enter. ");
                string input = Console.ReadLine();
                if (input.Trim() != "q") {
                    UserInput(input);
                }

                else {
                    break;
                }
            }
        }

        public void UserInputEventHandler(string input)
        {
            Console.WriteLine("You typed {0}", input);
        }

    }
}
