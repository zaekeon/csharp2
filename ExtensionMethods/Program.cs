using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string post = "This is supposed to be a very long blog post blah blah blah";
            var shortenedPost = post.Shorten(5);
            Console.WriteLine(shortenedPost);

            string post2 = "This is the last";
            Console.WriteLine(post2);
            var post3 = post2.AddToEnd("song");
            Console.WriteLine(post3);

            

            
        }
    }


    //You create a static class (that's needed)
    //A good convention is to use the class name and then Extensions
    public static class StringExtensions
    {

        //the format of this is <MethodName>(this <type you're extending> <tempvaariablenameforthatobject>, <method params>)
        public static string Shorten(this String str, int numberOfWords)
        {
            if (numberOfWords < 0)
            {
                throw new ArgumentOutOfRangeException("Number of words should be great than or equal to zero");
            }

            if (numberOfWords == 0)
            {
                return "";
            }

            var words = str.Split(' ');

            if (words.Length <= numberOfWords)
            {
                return str;
            }

            return string.Join(" ", words.Take(numberOfWords));
        }
    }

    public static class StringExtensions2
    {
        public static string AddToEnd(this String str, string addOn)
        {

            return str + " "  + addOn;
        }

    }
}
