using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression2
{
    class Program
    {
        static void Main(string[] args)
        {

           

            Console.WriteLine("Fun with Lambdas");
            TraditionalDelegateSyntax();
            Console.ReadLine();


        }

        static void TraditionalDelegateSyntax()
        {
            //make list of ints
            List<int> list = new List<int>();
            list.AddRange(new int[] { 20, 1, 4, 8, 9, 44 });

            //call findall using traditional delegate syntax

            Predicate<int> callback = IsEvenNumber;
            List<int> evenNumbers = list.FindAll(callback);

            Console.WriteLine("Here are your even numbers");
            foreach (int evenNumber in evenNumbers)
            {
                Console.Write("{0}\t", evenNumber);
            }
            Console.WriteLine();
        }

        /// <summary>
        /// 
        /// </summary>
        static void AnonymousMethodSyntax()
        {
            List<int> list = new List<int>();
            list.AddRange(new int[] { 20, 1, 4, 8, 9, 44 });

            //now use anonymouse method

            List<int> evenNumbers = list.FindAll(delegate (int i)
            { return (i % 2) == 0; });

            Console.WriteLine("Here are your even numbers:");
            foreach (int evenNumber in evenNumbers)
            {
                Console.Write("{0}\t", evenNumber);
            }
        }

        static void LambdaExpressionSyntax()
        {
            List<int> list = new List<int>();
            list.AddRange(new int[] { 20, 1, 4, 8, 9, 44 });

            //now use lamdba

            List<int> evenNumbers = list.FindAll(i => (i % 2) == 0);

            Console.WriteLine("Here are your even numbers");
            foreach(int evenNumber in evenNumbers)
            {
                Console.WriteLine("{0}\t", evenNumber);
            }
            Console.WriteLine();
        }

        //target for predicate<>delegate
        static void LambdaExpressionSyntaxMultiple()
        {
            List<int> list = new List<int>();
            list.AddRange(new int[] { 20, 1, 4, 8, 9, 44 });

            //now use lamdba

            List<int> evenNumbers = list.FindAll(i =>
            {
                Console.WriteLine("value of i is currently:");
                bool isEven = ((i % 2) == 0);
                return isEven;
            }
            );
            Console.WriteLine("Here are your even numbers");
            foreach (int evenNumber in evenNumbers)
            {
                Console.WriteLine("{0}\t", evenNumber);
            }
            Console.WriteLine();
        }
        static bool IsEvenNumber(int i)
        {
            return (i % 2) == 0;
        }
    }
}
