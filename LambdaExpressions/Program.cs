using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {

            //anonymous method
            //no access modifer
            //no name
            //no return statement.

            //why use anonymous method? for convenience

            //example:

            //takes a number and returns a square of that number...
            //typically you would do this (see square method)

            Console.WriteLine(Square(5));

            //lambda example

            //syntax  

            //args => expression
            //args goes to expression

            //number => number * number;

            //to get the 'return' action we have to assign it to a delegate
            //we use func because we want to return a value
            //in the func the first argument is the argument type for the method and 2nd is the datastype for the return value

            Func<int, int> square = number => number * number;



            //calling the delegate here
            Console.WriteLine(square(9));

            //if you don't need any arguments you write a lambda expression like this:
            //() => ...

            //1 argument
            // x => ...

            //multiple args
            //(x,y,z) => ...

            //scope - lambda has access to variables passed and anythign defined in the function the lambda was created in.

            const int factor = 5;

            Func<int, int> multiplier = n => n * factor;
            Console.WriteLine(multiplier(6));

            //more practical and common usecase of lambda expression

            //write code to return all books that are less than 10 dollars
            //traditional way

            var books = new BookRepository().GetBooks();


            //the findall function gets a predicate method passed
            //predicate is a deleagate pointing to a function.
            //this basically iterates through the method and return it if the condition is sastisfied in the results.

            var cheapBooks = books.FindAll(IsCheaperThan10Dollars);

            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }



            //now let's the above with a lambda

            //the problem is everytime you want to call find you have to go create a method etc.
            //with a lamdba you can do this:

            var cheapBooks2 = books.FindAll(book => book.Price < 10);

            //in c# it's pretty common to just use a single letter with the lamdba arguments.
            //in the exmaple above we are working with books you could change the line above to

            //var cheapBooks2 = books.FindAll(b => b.Price < 10);

            Func <int, int> DoAdd = addme => addme + 5;
            Console.WriteLine(DoAdd(5));

        }

        static bool IsCheaperThan10Dollars(Book book)
        {
            return book.Price < 10;
        }

        static int Square(int number)
        {
            return number * number;
        }

    }
}
