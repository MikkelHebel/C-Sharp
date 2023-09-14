using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace firstProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initalize variables
            string myString = "This is my weird text string";
            int index = 0;

            // Print out
            while (index < myString.Length) {
                if (index % 2 != 1) {
                    char output = myString[index];
                    Console.WriteLine("Index: {0}, {1}", index, output);
                }
                index++;
            }
            /*
            Public: Access modifier
            Int: Return type
            Sum: Method name
            (int x, int y): Parameters/inputs and their datatype
            */

            public int Sum(int x, int y)
            {
                return x + y;
            }

            Calculator calc = new Calculator();
            Console.WriteLine(calc.Sum(5, 10));

            // Debug
            Console.ReadLine();
        }
    }
}