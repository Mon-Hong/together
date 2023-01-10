using System;

namespace _11
{
    class Teat
    {
        static int sum = 0,y;
        static void Main()
        {
            Console.Write("sum = {0}", sum);
            Add(2);
            Console.Write("sum = {0}", sum);

            Console.Write("sum = {0}", y);
        }

        static void Add(int y)
        {
            sum += y;
        }


    }
}
