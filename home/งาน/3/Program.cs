using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            char n;
            Console.Write(" Input grade : ");
            n = char.Parse(Console.ReadLine());

            
            switch(n)
            {
                case 'A':
                    Console.WriteLine(" Your point is 4.0");
                    break;
                case 'B':
                    Console.WriteLine(" Your point is 3.0");
                    break;
                case 'C':
                    Console.WriteLine(" Your point is 2.0");
                    break;
                case 'D':
                    Console.WriteLine(" Your point is 1.0");
                    break;
                case 'F':
                    Console.WriteLine(" Your point is 0.0");
                    break;
                default:
                    Console.WriteLine(" No grade");
                    break;
            }
            */

            /*
            if (n == 'A')
            {
                Console.WriteLine(" Your point is 4.0");
            }
            else if (n == 'B')
            {
                Console.WriteLine(" Your point is 3.0");
            }
            else if (n == 'C')
            {
                Console.WriteLine(" Your point is 2.0");
            }
            else if (n == 'D')
            {
                Console.WriteLine(" Your point is 1.0");
            }
            else if (n == 'F')
            {
                Console.WriteLine(" Your point is 0.0");
            }
            else
            {
                Console.WriteLine(" No grade");
            }
            */

            int n = 0, num = 1, sum = 0;
            Console.Write(" input :");
            num = int.Parse(Console.ReadLine());
            while (n <= num)
            {
                sum = sum + n++;
            }
            Console.WriteLine("Sum : {0} ", sum);



            Console.ReadLine();

        }
    }
}
