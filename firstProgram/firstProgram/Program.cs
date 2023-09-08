namespace firstProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? name;
            int age;

            // Ask for name
            Console.WriteLine("Input name: ");
            name = Console.ReadLine();

            // Ask for age
            Console.WriteLine("Input age: ");            
            // Continuesly check for age until a valid input is given
            while (true) {
                if (int.TryParse(Console.ReadLine(), System.Globalization.NumberStyles.Integer, null, out age))
                    break;
                Console.WriteLine("Invalid input! Try again.");
            }

            if (12 > age)
                Console.WriteLine("Et barn");
            else if (19 >= age)
                Console.WriteLine("En teenager");
            else if (25 >= age)
                Console.WriteLine("En studerende");
            else if (67 >= age)
                Console.WriteLine("I arbejde");
            else
                Console.WriteLine("En pensionist");

            Console.WriteLine("Hello {0}, you are {1} years old.", name, age);
            Console.WriteLine("In 120 years you will be {0} years old.", age+120);
            Console.ReadLine();
        }
    }
}