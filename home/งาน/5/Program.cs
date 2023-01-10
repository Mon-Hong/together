using System;

namespace _5
{
    class Program
    {
        private static int x,y,z;

        static void Main(string [] args)
        {
            MAX(x, y, z);
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            z = int.Parse(Console.ReadLine());
            int num = MAX(x, y, z);
            Console.WriteLine("\n"+ num);


        }
        static int MAX (int x , int y , int z)
        {
            int num;
            if (x >= y && x >= z) return x;
            else if (y >= x && y >= z) return y;
            else return z;
            return num;
        }


    }
}
