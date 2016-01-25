using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListCollections
{
    class Program
    {
        static void Main(string[] args)
        {


            const int BIBLIOGRAPHY_ID = 1039;
            Myth kingOfIthaca = new Myth("Odysseus", "Ulysses");
            KeyValuePair<int, Myth> kvp = new KeyValuePair<int, Myth>(BIBLIOGRAPHY_ID, kingOfIthaca);

            Console.WriteLine("Key = {0}", kvp.Key);
            Console.WriteLine("Value = {0}", kvp.Value.GreekName);
            Console.WriteLine("Value = {0}", kvp.Value.RomanName);
            Console.ReadLine();



            List<string> collection = new List<string>();
            AddItems(collection);
            ShowItems(collection);
            RemoveItems(collection);
            ShowItems(collection);
            Console.ReadLine();

            List<Account> accountList = new List<Account>();

            accountList.Add(new Checking());
            accountList.Add(new Savings());
     

            foreach (Account item in accountList)
            {
                item.DisplayDetail();
            }
            
        }

        public static void AddItems(List<string> collection)
        {
            collection.Add("Al");
            collection.Add("Ed");
            collection.Insert(1, "Bob");

            List<string> subCollection = new List<string>();
            subCollection.Add("Cal");
            subCollection.Add("Dora");

            collection.InsertRange(2, subCollection);

        }

        public static void ShowItems(List<string> collection)
        {
            foreach (string item in collection)
            {
                Console.WriteLine(item);
            }
                   
        }

        public static void RemoveItems(List<string> collection)
        { collection.Remove("Dora");
            collection.RemoveAt(0);
        }

    }
}
