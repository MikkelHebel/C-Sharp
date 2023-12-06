namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Welcome to super uper duper omega nice calculator! :D");
                Console.WriteLine("Please choose what type of calculation you want to perform:");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Division");
                Console.WriteLine("4. Multiplication");

                // Start method
<<<<<<< HEAD
                Calculator regner = new Calculator();
=======
                Lommeregner regner = new Lommeregner();
>>>>>>> 87531e7797464f76470a876cbc6809fdba3c8f80

                string? ans = Console.ReadLine();
                int.TryParse(ans, out int number);

                // Get input 1
                string? input1 = Console.ReadLine();
                int.TryParse(input1, out int x);

                // Get input 2
                string? input2 = Console.ReadLine();
                int.TryParse(input2, out int y);

                switch (number)
                {
                    case 1:
                        Console.WriteLine("Addition:");
                        int result = regner.Add(x, y);
                        Console.WriteLine(result);
                        break;
                    case 2:
                        Console.WriteLine("Subtract:");
                        int result2 = regner.Subtract(x, y);
                        Console.WriteLine(result2);
                        break;
                    case 3:
                        Console.WriteLine("Divison:");
                        double result3 = regner.Divide(x, y);
                        Console.WriteLine(result3);
                        break;
                    case 4:
                        Console.WriteLine("Multiplication:");
                        int result4 = regner.Multiply(x, y);
                        Console.WriteLine(result4);
                        break;
                    default:
                        Console.WriteLine("Error!");
                        break;
                }

            } while (true);
        }
    }
}