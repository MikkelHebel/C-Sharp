using System.ComponentModel.DataAnnotations;

namespace TextStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myString = "My little test string used for lots of stuff!";
            Console.WriteLine(myString);

            // Outputs string length
            Console.WriteLine(myString.Length);

            string substr1 = myString.Substring(0, 5); // Prints the 0-5 characters
            string substr2 = myString.Substring(6); // Prints the 6. character and everything after.
            string substr3 = myString.Substring(10, 11); // 10 is the starting position of the substring,
                                                         // while 11 is the length of text we want after the starting position.
            Console.WriteLine(substr1);
            Console.WriteLine(substr2);
            Console.WriteLine(substr3);
            Console.WriteLine("");


            // String testing
            string str = "Another testing string!";

            // Finding the index of character
            // which is present in a string.
            int index1 = str.IndexOf('!');

            // This will only return the first t found in the string.
            int index2 = str.IndexOf('t');

            Console.WriteLine("The Index Value of character '!' is " + index1);
            Console.WriteLine("The Index Value of character 't' is " + index2);
            Console.WriteLine("");


            // String search.
            Console.WriteLine("Search for a character in a custom string! First input your string:");
            string? stringToSearch = Console.ReadLine();
            Console.WriteLine("Your string: " + stringToSearch);

            Console.WriteLine("Now specify a charachter to search for:");
            char search = Console.ReadLine()[0];
            Console.WriteLine("Searchin for: " + search);
            int index = stringToSearch.IndexOf(search);

            if (index != -1)
            {
                Console.WriteLine("The charahcter was found at: " + index);
            }
            else
            {
                Console.WriteLine("The charahcter was not found!");
            }

            Console.ReadLine();
        }
    }
}