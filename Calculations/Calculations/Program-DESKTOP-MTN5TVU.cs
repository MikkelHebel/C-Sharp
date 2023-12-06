namespace Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Choose calcuation type
            Console.WriteLine("Welcome. Please choose a calculation type.");
            Console.WriteLine("");
            Console.WriteLine("1. Area of a rectangle");
            Console.WriteLine("2. Slope of line segment");
            Console.WriteLine("3. X");

            int answer;
            while (!int.TryParse(Console.ReadLine(), System.Globalization.NumberStyles.Integer, null, out answer))
            {
                Console.WriteLine("Invalid input!");
            }
            Console.WriteLine("You have chosen {0}", answer);



            // If we want to calculate rectangle.
            if (answer == 1) {
                int input1;
                int input2;

                Console.WriteLine("Please input a height of the rectangle.");
                while (!int.TryParse(Console.ReadLine(), System.Globalization.NumberStyles.Integer, null, out input1))
                {
                    Console.WriteLine("Invalid input!");
                }

                Console.WriteLine("Please input a width of the rectangle.");
                while (!int.TryParse(Console.ReadLine(), System.Globalization.NumberStyles.Integer, null, out input2))
                {
                    Console.WriteLine("Invalid input!");
                }
                Console.WriteLine("Height set to {0} and width set to {1}", input1, input2);

                int output = input1 * input2;
                Console.WriteLine("Area: {0}", output);
            }

            // If we want to calculate Slope of line segment.
            if (answer == 2) {
                double x1, y1, x2, y2;

                Console.WriteLine("Input x1.");
                while (!double.TryParse(Console.ReadLine(), System.Globalization.NumberStyles.Number, null, out x1))
                {
                    Console.WriteLine("Invalid input!");
                }

                Console.WriteLine("Input y1.");
                while (!double.TryParse(Console.ReadLine(), System.Globalization.NumberStyles.Number, null, out y1))
                {
                    Console.WriteLine("Invalid input!");
                }

                Console.WriteLine("Input x2.");
                while (!double.TryParse(Console.ReadLine(), System.Globalization.NumberStyles.Number, null, out x2))
                {
                    Console.WriteLine("Invalid input!");
                }

                Console.WriteLine("Input y2.");
                while (!double.TryParse(Console.ReadLine(), System.Globalization.NumberStyles.Number, null, out y2))
                {
                    Console.WriteLine("Invalid input!");
                }
                Console.WriteLine("x1: {0}, y1: {1}, x2: {2}, y2: {3}", x1, y1, x2, y2);

                double output = (y2 - y1) / (x2 - x1);
                Console.WriteLine("Result: {0}", output);
            }

            if (answer == 3) {
                Console.WriteLine("X");
            }

            Console.WriteLine("Press any key to close");
            Console.ReadLine();
        }
    }
}