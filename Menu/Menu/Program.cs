namespace Menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menu");
            Console.WriteLine("");
            Console.WriteLine("1. Gør dit");
            Console.WriteLine("2. Gør dat");
            Console.WriteLine("3. Gør noget");
            Console.WriteLine("4. Få svaret på livet, universet og alting.");
            Console.WriteLine("");
            Console.WriteLine("Skriv et tal mellem 1-4 for at vælge.");

            int answer;

            while (!int.TryParse(Console.ReadLine(), System.Globalization.NumberStyles.Integer, null, out answer)) {
                Console.WriteLine("Invalid input!");
            }
            Console.WriteLine("Du har valgt {0}", answer);

            switch (answer) {
                case 1:
                    Console.WriteLine("Vi gør dit.");
                    break;
                case 2:
                    Console.WriteLine("Vi gør dat.");
                    break;
                case 3:
                    Console.WriteLine("Vi gør noget.");
                    break;
                case 4:
                    Console.WriteLine("42");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }

            Console.ReadLine();
        }
    }
}