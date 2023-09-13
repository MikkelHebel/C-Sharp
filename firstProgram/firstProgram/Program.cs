using System.ComponentModel.DataAnnotations;

namespace firstProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a input:");
            // Initalize variables
            int a;
            int b;

            // Get input1
            while (!int.TryParse(Console.ReadLine(), out a)) {
                Console.WriteLine("Invalid input!");
            }

            // Get input2
            while (!int.TryParse(Console.ReadLine(), out b) || b == 0) {
                Console.WriteLine("Invalid input!");
            }

            int output = a / b;
            int output2 = a % b;

            Console.WriteLine("A: {0} B: {1}", a, b);
            Console.WriteLine("Heltalskvotienten: {0}", output);

            Console.WriteLine("Rest delen: {0}", output2);

            // Debug
            Console.ReadLine();


        }
    }
}