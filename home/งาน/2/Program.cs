using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*double num;

            Console.Write("Input x : ");
            num = double.Parse(Console.ReadLine());

            num = Math.Abs(num);

            Console.WriteLine("X = {0}", num);*/

            /*float num, x;

            Console.Write("Input x : ");
            num = float.Parse(Console.ReadLine());

            if (num >=0)
            {
                Console.WriteLine("X = "+ num);
            }

            else if(num < 0)
            {
                num = -num;
                Console.WriteLine("X = " + num);

            }*/

            double num, x;
            Console.Write("Input x : ");
            num = double.Parse(Console.ReadLine());

            if (num <= 5)
            {
                x = (2 * num) + 10;
                Console.WriteLine("funcction value of X according with {0:f2}", x);
            }
            else if (num > 5 && num <= 20)
            {
                x = (num * num) + 10;
                Console.WriteLine("funcction value of X according with {0:f2}", x);
            }
            else if (num > 20)
            {
                x = (num * num * num) + 10;
                Console.WriteLine("funcction value of X according with {0:f2}", x);
            }

            Console.ReadLine();
        }
    }
}
