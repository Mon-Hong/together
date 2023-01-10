using System;

namespace Computer_Programming_for_Media
{
    class Program
    {
        static void Main(string[] args)
        {
            int day, time;

            Console.Write("Input day : ");
            day = int.Parse(Console.ReadLine());

            Console.Write("Input time : ");
            time = int.Parse(Console.ReadLine());


            int breakfast, weekend, coffe;

            breakfast = 5;
            weekend = 5;
            coffe = 2;

            string menu;

            do
            {
                Console.Write("Input menu : ");
                menu = Console.ReadLine();

                if (menu == "Breakfast")
                {
                    if (time > 11)
                    {
                        Console.WriteLine("Sorry your order is not available");
                    }
                    if (breakfast == 0)
                    {
                        Console.WriteLine("Sorry your order is out of stock");
                    }
                    if (time >= 8 && time <= 11 && breakfast != 0)
                    {
                        breakfast = breakfast - 1;
                    }

                }

                if (menu == "Weekend")
                {
                    if (day >= 1 && day <= 5)
                    {
                        Console.WriteLine("Sorry your order is not available");
                    }
                    if (weekend == 0)
                    {
                        Console.WriteLine("Sorry your order is out of stock");
                    }
                    if (day == 6 || day == 7 && time >= 8 && time <= 18 && weekend != 0)
                    {
                        weekend = weekend - 1;
                    }

                }

                if (menu == "Coffe")
                {
                    if (coffe == 0)
                    {
                        Console.WriteLine("Sorry your order is out of stock");
                    }
                    if (day >= 1 && day <= 7 && time >= 8 && time <= 18 && coffe != 0)
                    {
                        coffe = coffe - 1;
                    }
                }
                if (menu == "End")
                {

                }

                else
                {
                    Console.WriteLine("Please enter a valid menu");

                }

            }

            while (menu != "End");



            Console.ReadLine();
        }
    }
}
