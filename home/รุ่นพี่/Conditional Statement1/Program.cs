using System;

namespace Conditional_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;

            Console.Write(" Input mode : ");
            string mode = Console.ReadLine();

            Console.Write(" Input X : ");
            x = double.Parse(Console.ReadLine());
            Console.Write(" Input Y: ");
            y = double.Parse(Console.ReadLine());

            if (mode == "time" && x >= 0)
            {
                Console.WriteLine( x + " , " + Math.Pow(x - 1, 2));
            }
            else if (mode == "price" && x < 1 && y < 1 && x >= 0)
            {
                Console.WriteLine(-Math.Sqrt(y) + 1 + " , " + y);
            }
            else if (mode == "price" && x >= 1)
            {
                Console.WriteLine(Math.Sqrt(y) + 1 + " , " + y);
            }
            else if (x < 0)
            {
                Console.WriteLine(" Invalid mouse position");
            }
            else if (mode != "time" && mode != "price")
            {
                Console.WriteLine(" Invalid mode");
            }

            Console.ReadLine();
        }
    }
}
