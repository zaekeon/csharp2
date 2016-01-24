using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLecture
{
    class Program
    {
        static void Main(string[] args)
        {

            //Language Integrated Query

            //Query in memory lik ecollections
            //query dbs
            //query xml
            //ado.net datasets

            //linq to objects = memory/collections
            //linq to entites = database
            //linq to xml
            //linq to data sets

            IEnumerable<Book> books = new BookRepository().GetBooks();
            //could have been var

            //without linq to search we would do this

            var cheapBooks = new List<Book>();
            foreach (var book in books)
            {
                if (book.Price < 10)
                    cheapBooks.Add(book);

            }

            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title + " " + book.Price);
            }


            //with linq we can do this

            //LINQ Query Operators

            var cheaperBooks = from b in books
                               where b.Price < 10
                               orderby b.Title
                               select b.Title;


            //LINQ Extension Methods
            var cheapBookLINQ = books
                                    .Where(b => b.Price < 10)
                                    .OrderBy(b => b.Title)
                                    .Select(b => b.Title);

            foreach(var item in cheapBookLINQ)
            {
                Console.WriteLine(item);
            }

            var singleBook = books.Single(b => b.Title == "ASP.NET MVC");

            Console.WriteLine(singleBook.Title);

            var singleBook2 = books.SingleOrDefault(b => b.Title == "ASP.NET MVC");

            Console.WriteLine(singleBook2.Title);

            


        }
    }
}
