using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace HashTableExercrise
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable bacon = new Hashtable();

            bacon.Add(208, 44.33f);
            bacon.Add(322, 34.22f);
            bacon.Add("YRC", "Packing List - Jan 28");

            //remember for hastable it's a dictionaryentry
            //for dictionary it's a keyvaluepair

            foreach (DictionaryEntry item in bacon)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }

        }
    }
}
