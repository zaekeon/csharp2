using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SystemIO
{
    class Program
    {
        static void Main(string[] args)
        {

            //Binary writing/reading
            WriteOutput();
            DisplayInput();
            BinaryWriterTest();

            //text reading/writing
            WriteToCSV();
            ReadFromCSV();

            CreateFile();

            //create a directory
            Directory.CreateDirectory(@"c:\testdir");


            //delete a directory

            Directory.Delete(@"c:\testdir");

            //list files in a directory

            string[] files = Directory.GetFiles(@"c:\projects");

            ListFiles(files);
            StreamReaderExample();
            StreamWriterExample();
            StreamWriter2Example();
            StreamReader2Example();



        }



        private static void WriteOutput()
        {
            try
            {
                //create file and write to it with a BinaryWriter object.
                using (BinaryWriter writer =  new BinaryWriter(File.Open(@"c:\projects\binary2.txt", FileMode.Create)))
                {
                    writer.Write(true);
                    writer.Write('A');
                    writer.Write(1.1m);
                    writer.Write(2.2);
                    writer.Write(3.3f);
                    writer.Write(4);
                    writer.Write("Hello");
                    writer.Write("James");
                    writer.Write("Bond");
                    writer.Write(7);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void DisplayInput()
        {
            const string FILE_PATH = @"c:\projects\binary2.txt";

            try
            {
                using (BinaryReader reader = new BinaryReader(File.Open(FILE_PATH, FileMode.Open)))
                {
                    //read known formats in a known order
                    Console.WriteLine(reader.ReadBoolean());
                    Console.WriteLine(reader.ReadChar());
                    Console.WriteLine(reader.ReadDecimal());
                    Console.WriteLine(reader.ReadDouble());
                    Console.WriteLine(reader.ReadSingle());
                    Console.WriteLine(reader.ReadInt32());
                    Console.WriteLine(reader.ReadString());
                    Console.WriteLine(reader.ReadString());
                    Console.WriteLine(reader.ReadString());
                    Console.WriteLine(reader.ReadInt32());

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void BinaryWriterTest()
        {
            const string FILE_PATH = @"c:\projects\binaryfile.txt";
            using (BinaryWriter writer = new BinaryWriter(File.Open(FILE_PATH, FileMode.Create)))
            {
               writer.Write("ABC");
               writer.Write(123);
               
            }
        }

        private static void WriteToCSV()
        {
            const string FILE_PATH = @"c:\projects\mycsv.csv";

            try
            {
                using (StreamWriter sw = new StreamWriter(FILE_PATH, true))
                {
                    sw.WriteLine("Monthly Sales,Amount");
                    sw.WriteLine("August,23333.25");
                    sw.WriteLine("September,18323.22");
                    sw.WriteLine("October,13344.23");
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error Writing to freaking file!!!!!!!" + e.Message);
            }
        }

        private static void ReadFromCSV()
        {
            const string FILE_PATH = @"c:\projects\mycsv.csv";
            double sum = 0;

            try
            {
                using (StreamReader reader = new StreamReader(FILE_PATH))
                {

                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        Console.WriteLine("Line content: " + line);

                        string[] contents = line.Split(',');
                        foreach (string item in contents)
                        {

                            double intValue;
                            bool success = double.TryParse(item, out intValue);
                            if (success)
                            {
                                sum += intValue;
                            }
                            Console.WriteLine("Array contents: " + item);
                            Console.WriteLine("Current total is:" + sum);
                        }
                   
                    }
                    Console.WriteLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error reading file...maybe the bacon got it?");
            }
        }

        private static void StreamReader2Example()
        {
            const string FILE_PATH = "../../Budget.csv";
            ReadFromFile(FILE_PATH);
            Console.ReadLine();
        }

        private static void ReadFromFile(string filePath)
        {
            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine("Entire line: " + line);
                        string[] contents = line.Split(',');
                        Console.WriteLine("Array values:");
                        foreach (string data in contents)
                        {
                            Console.WriteLine(data + " * ");

                        }
                        Console.WriteLine("\n");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Read error: " + e.Message);
            }
        }

        private static void StreamWriter2Example()
        {
            const string FILE_PATH = "../../Budget.csv";
            WriteToFile(FILE_PATH);
            
        }

        private static void WriteToFile(string path)
        {
            const bool APPEND = true;
            try
            {
                //create writer to add or append to a file.
                using (StreamWriter sw = new StreamWriter(path, !APPEND))
                {
                    sw.WriteLine("Category, Transation Amount, Balance");
                    sw.WriteLine("Food, 123.45, 220.98");
                    sw.WriteLine("Phone, 40.00, 180.98");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Write Error: " + e.Message);
            }
        }
            

        private static void StreamWriterExample()
        {
            //writing
            //a writer can write text or other formats of data
            //there are several overloads for each data type.
            //you can do a Write or a WriteLine which will add a line terminator automatically

            Console.WriteLine("Please type some text");
            Console.WriteLine("Enter an empty line to exit");

            using (StreamWriter writer = new StreamWriter(@"c:\projects\test.txt"))
            {
                string input = Console.ReadLine();
                while (input.Trim().Length != 0)
                {
                    writer.WriteLine(input);
                    input = Console.ReadLine();
                }
            }
        }

        private static void StreamReaderExample()
        {
            //streams
            //you can make a stream manually from a filestream or you can grab one from another object such as File.
            //you could also just make a streamreader manually using a path.

            //this try block is just here for demo. You'd want to use the USING method in a real application.
            try
            {
                FileStream filestream = new FileStream(@"c:\projects\test2.txt", FileMode.OpenOrCreate);

                //getting a stream from the static File.OpenText 
                StreamReader reader = File.OpenText(@"c:\projects\test2.txt");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error opening files");
            }
            finally
            {

            }

            //a streamreader can read one character at a time, or a buffer of characters at a time (a char array) or ReadLine() method at a time.
            //Readline returns a string.

            try
            {
                using (StreamReader reader2 = File.OpenText(@"c:\projects\test.txt"))
                {
                    string line;
                    //read and display lines from the file
                    while ((line = reader2.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void ListFiles(string[] files)
        {

            //list file in a directory method2
            DirectoryInfo dir = new DirectoryInfo(@"c:\projects");
            FileInfo[] files2 = dir.GetFiles();

            Console.WriteLine("Printing from string array");
            foreach (var item in files)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Printing from the FileInfo array");
            Console.WriteLine();
            foreach (var item in files2)
            {
                Console.WriteLine(item.Name);
            }
        }

        private static void CreateFile()
        {

            //create and delete a file
            string fileName = @"c:\projects\test.txt";

            try
            {
                if (!File.Exists(fileName))  //check to make sure we don't overwrite an existing file
                {
                    using (FileStream fs = File.Create(fileName))
                    {
                        
                        
                    }
                }

                File.Copy(fileName, @"c:\projects\test2.txt");  //copy a file

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
