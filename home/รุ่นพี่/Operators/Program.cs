using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int num0, num1, num2, num3, num4, num5, num6;
            string code;

            Console.Write(" Password : ");
            num0 = int.Parse(Console.ReadLine());

            Console.Write(" Code : ");
            code = Console.ReadLine();


            num1 = num0 % 10;

            num2 = num0 % 100;
            num2 = num2 / 10;

            num3 = num0 % 1000;
            num3 = num3 / 100;

            num4 = num0 % 10000;
            num4 = num4 / 1000;

            num5 = num0 % 100000;
            num5 = num5 / 10000;

            num6 = num0 % 1000000;
            num6 = num6 / 100000;


            if (code == "CIA")
            {
                bool a = (num1 % 3 == 0) && ((num2 != 1) && (num2 != 3) && (num2 != 5)) && ((num4 == 6) || (num4 == 7) || (num4 == 9));
                Console.WriteLine(a);
            }
            else if (code == "FBI")
            {
                bool b = ((num6 <= 8) && (num6 >= 4)) && ((num3 % 2 == 0) && (num3 != 6)) && (num5 % 2 != 0);
                Console.WriteLine(b);
            }
            else if (code == "NSA")
            {
                bool c = ((num1 == 1) || (num1 == 2) || (num1 == 3) || (num1 == 5) || (num1 == 6)) && ((num3 % 3 == 0) && (num3 % 2 != 0)) && ((num2 == 7) || (num4 == 7) || (num5 == 7) || (num6 == 7));
                Console.WriteLine(c);
            }
            else
            {
                Console.WriteLine("Who are you?");
            }

            Console.ReadLine();
        }
    }
}
