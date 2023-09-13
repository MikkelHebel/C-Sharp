using System.ComponentModel.DataAnnotations;

namespace firstProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? str = "";

            do
            {
                str = Console.ReadLine();
            } while (!(str.Length > 5));
            Console.WriteLine(str[3]);
            Console.WriteLine(str[2]);
            Console.WriteLine(str[4]);
            Console.ReadLine();
        }
    }
}