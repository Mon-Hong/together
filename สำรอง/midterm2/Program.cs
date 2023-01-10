using System;

namespace MDT112midterm2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, x, y;

            Console.Write("Input number a : ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Input number b : ");
            b = int.Parse(Console.ReadLine());

            x = a;
            y = b;

            while (x != y)
            {
                if (x < y)
                {
                    x = x + a;
                }
                else
                {
                    y = y + b;
                }
            }

            if (x == y)
            {
                Console.WriteLine(x);
            }
            Console.ReadLine();
        }
    }
}
