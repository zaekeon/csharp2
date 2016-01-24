using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLecture
{
    public class Book
    {
        

        public float Price { get; set;}
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
