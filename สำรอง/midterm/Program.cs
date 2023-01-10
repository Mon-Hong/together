
using System;

namespace midterm
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write(" Input number : ");
            int num = int.Parse(Console.ReadLine());
            int i = 0, j ;

            while (i < num)
            {
                j = num - i;

                while (j > 0)
                {
                    Console.WriteLine("*");
                    j = j - 1;
                }
                    Console.WriteLine("");
                    i = i + 1;
            }
            

            /*
            int a, b, x, y;

            Console.Write("Input number a : ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Input number b : ");
            b = int.Parse(Console.ReadLine());

            x = a;
            y = b;

            while ( x != y)
            {
                if(x < y)
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
            */
            /*
            int box, bucket,bucket1, bucket2, bucket3;

            Console.Write("input box bucket1 : ");
            bucket1 = int.Parse(Console.ReadLine());

            Console.Write("input box bucket2 : ");
            bucket2 = int.Parse(Console.ReadLine());

            Console.Write("input box bucket3 : ");
            bucket3 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nStart");

            while (bucket1 > 0 || bucket2 > 0 || bucket3 > 0)
            {

                Console.WriteLine("\nQueue A");

                Console.WriteLine("bucket1 : {0} , bucket2 : {1} , bucket3 : {2}", bucket1, bucket2, bucket3);

                Console.Write("Input bucket number : ");
                bucket = int.Parse(Console.ReadLine());

                Console.Write("Input bucket number : ");
                box = int.Parse(Console.ReadLine());

                switch (bucket)
                {
                    case 1:
                        bucket1 = bucket1 - box;
                        break;

                    case 2:
                        bucket2 = bucket2 - box;
                        break;

                    case 3:
                        bucket3 = bucket3 - box;
                        break;
                }
                if (bucket1 == 0 && bucket2 == 0 && bucket3 == 0)
                    { 
                        Console.WriteLine("\n\n--- B ---\n---win---\nEnd game");
                        break;
                }

                Console.WriteLine("\nQueue B");

                Console.WriteLine("bucket1 : {0} , bucket2 : {1} , bucket3 : {2}", bucket1, bucket2, bucket3);
                
                Console.Write("Input bucket number : ");
                bucket = int.Parse(Console.ReadLine());

                Console.Write("Input bucket number : ");
                box = int.Parse(Console.ReadLine());

                switch (bucket)
                {
                    case 1:
                        bucket1 = bucket1 - box;
                        break;

                    case 2:
                        bucket2 = bucket2 - box;
                        break;

                    case 3:
                        bucket3 = bucket3 - box;
                        break;
                }
                if (bucket1 == 0 && bucket2 == 0 && bucket3 == 0)
                {
                    Console.WriteLine("\n\n--- A ---\n---win---\nEnd game");
                    break;
                }
            }
            */
            Console.ReadLine();
        }
    }
}
