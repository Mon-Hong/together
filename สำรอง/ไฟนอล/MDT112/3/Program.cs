using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            string num, min ,max ,mean = "0";


            double number;
            do
            {
                
                Console.Write("Input number : ");
                num = Console.ReadLine();

                number = Convert.ToInt32(num);

                mean = number + mean;
            } while (num != "End");

            



            

            Console.Write(mean);

        }
    }
}
