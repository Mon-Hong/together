using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            float num;

            Console.Write(" Input number : ");
            num = float.Parse(Console.ReadLine());

            if (num <= 0 && num >0)
            {
                Console.WriteLine(" This is a number.");

                if (num % 1 == 0)
                
                    Console.WriteLine(" This is an integer.");

                    if (num > 0)
                    
                        Console.WriteLine(" This is an positive number.");
                    
                    else if (num < 0)
                    
                        Console.WriteLine(" This is a negative number.");
                    
                    else
                    
                        Console.WriteLine(" This is a zero.");
                    

                if (num%1 != 0)         
                    Console.WriteLine(" This is not an integer.");
                
            }
            else
            {
                
            }


            Console.ReadLine();
        }
    }
}
