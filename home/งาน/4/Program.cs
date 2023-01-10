using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int num , sum = 0 ;
            Console.Write("Please input number : ");
            num = int.Parse(Console.ReadLine());

            for (int i = 0; i <= num; ++i)
            {
                sum = sum + i*i;
          
            }
            Console.WriteLine("Sum = {0}", sum);*/

            /*int num = 0;
            Console.Write(" input :");
            num = int.Parse(Console.ReadLine());


            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= num; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }*/

            int num = 0;
            Console.Write(" input :");
            num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

           /* int num = 0;
            Console.Write(" input :");
            num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                for (int j = num; j > i; j--)
                    Console.Write(" ");
                { 
                    for (int j = 1; j <= (2*i)-1; j++)
                    {        
                            Console.Write("*");
                    }
                }
                Console.WriteLine();

            }*/
          
            }
        }
    }

