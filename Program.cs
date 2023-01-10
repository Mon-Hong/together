using System;

namespace X
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, num3, x;


            Console.Write(" number1 : ");
            num1 = double.Parse(Console.ReadLine());
            Console.Write(" number2 : ");
            num2 = double.Parse(Console.ReadLine());
            Console.Write(" number3 : ");
            num3 = double.Parse(Console.ReadLine());

            x = (num1 + num2 + num3) / 3;
            Console.WriteLine("Mean = {0}" , x);

        }
    }
}
