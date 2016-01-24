using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    public class Book
    {
        

        public int Price { get; set;}
        public string Title { get; set;}


        public Book()
        {

        }
        public Book(string title, int price)
        {
            Price = price;
            Title = title;
        }


    }
}
