using System;

namespace Homework1_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int num,x=0,y=0;

            do
            {
                Console.Write("Input number : ");
                num = int.Parse(Console.ReadLine());
                if (num < 0)
                {
                    Console.WriteLine("Invalid Pascal’s triangle row number.");
                }
            } while (num < 0);

            while (num >= x)
            {
                for (int i = 1; i <= num; i++)
                {
                    
                }
                for(int j = 0; j <= x; j++)
                {
                    if (j == 0 || x == 0)
                    {
                        y = 1;
                    }
                    else
                    {
                        Console.Write(" ");
                        y = y * (x - j + 1) / j;
                    }
                    Console.Write(y);
                }
                Console.Write("\n");
                x++;
            }

        }
    }
}
