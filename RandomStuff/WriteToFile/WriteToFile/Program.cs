using System;
using System.IO;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime start = DateTime.Now;
            Console.WriteLine("Datetime testing.");

            DateTime myValue = DateTime.Now;
            Console.WriteLine(myValue.ToString());
            Console.WriteLine(myValue.ToShortDateString());
            Console.WriteLine(myValue.ToShortTimeString());
            Console.WriteLine(myValue.ToLongDateString());

            Console.WriteLine(myValue.AddDays(3).ToLongDateString());

            Console.WriteLine("Checking text file..");
            try
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                //True = Append to file, false = overwrite
                StreamWriter sw = new StreamWriter("C:\\Users\\Mikkel Hebel\\Desktop\\Programming\\C#\\Test\\Test\\output.txt", false);
                //Write a line of text
                sw.WriteLine(myValue.ToString());
                sw.WriteLine(myValue.ToShortDateString());
                sw.WriteLine(myValue.ToShortTimeString());
                sw.WriteLine(myValue.ToLongDateString());
                //Write a second line of text
                sw.WriteLine("In 3 days the time will be:");
                sw.WriteLine(myValue.AddDays(3).ToLongDateString());
                //Close the file
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }

            DateTime end = DateTime.Now;
            Console.WriteLine("Time taken: " + (end - start).TotalMilliseconds + "ms");

            Person p;
            p = new Person();

            p.FirstName = "Gandalf";
            p.LastName = "The Grey";
            p.Age = 7908;

            Console.WriteLine(p);
            Console.WriteLine(p.Age);

            Console.ReadLine();
        }
    }
}