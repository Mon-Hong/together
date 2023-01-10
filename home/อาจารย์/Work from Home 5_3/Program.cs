using System;

namespace Work_from_Home_5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            double num;
            Console.Write(" Input number : ");
            num = double.Parse(Console.ReadLine());
       
            if (num == Math.Round(num))
            {
                Console.WriteLine(num + " is integer.");
            }
            else if (num != Math.Round(num))
            {
                Console.WriteLine(num + " is not integer.");
            }
            */
            /*
            char n;
            Console.Write(" Input Char : ");
            n = char.Parse(Console.ReadLine());

            if (n >= 'A' && n <= 'Z')
            {
                Console.WriteLine(" Upper case letter");
            }
            else if (n >= 'a' && n <= 'z')
            {
                Console.WriteLine(" Lower case letter");
            }
            else if (n >= '0' && n <= '9')
            {
                Console.WriteLine(" Digit.");
            }
            else
            {
                Console.WriteLine(" Others.")
            }
            */

            float x, y;
            Console.Write(" Input x : ");
            x = float.Parse(Console.ReadLine());
            Console.Write(" Input y : ");
            y = float.Parse(Console.ReadLine());

            if(x == 0 && y > 0)
            {
                Console.WriteLine(" +Y");
            }
            else if (x == 0 && y < 0)
            {
                Console.WriteLine(" -Y");
            }
            else if (x > 0 && y == 0)
            {
                Console.WriteLine(" +X");
            }
            else if (x < 0 && y == 0)
            {
                Console.WriteLine(" -X");
            }
            else if (x > 0 && y > 0)
            {
                Console.WriteLine(" Quadrant 1");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine(" Quadrant 2");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine(" Quadrant 3");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine(" Quadrant 4");
            }
            else
            {
                Console.WriteLine(" Origin");
            }

            Console.ReadLine();
        }
    }
}
