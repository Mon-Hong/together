using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstRoll = int.Parse(Console.ReadLine());
            int secondRoll = int.Parse(Console.ReadLine());
            if (firstRoll == secondRoll)
            {
                Console.WriteLine("Double!");
            }
            int total = firstRoll + secondRoll;
            if (total < 5)
            {
                if (total == 2)
                {
                    Console.WriteLine("Bad luck!");
                }
                Console.WriteLine("Low score.");
            }
            else if (total >= 5 && total <= 9)
            {
                Console.WriteLine("Average score.");
            }
            else
            {
                if (total == 12)
                {
                    Console.WriteLine("Good luck!");
                }
                Console.WriteLine("High score.");
            }


            Console.ReadLine();
        }
    }
}
