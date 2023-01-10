using System;

namespace homework_6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double volume1, price1, number1, xaverage1, volume2, price2, number2, xaverage2;
            string name1, name2, compare;
            int i = 0;

            Console.WriteLine("Next product {0}", ++i);

            Console.Write("Input product name : ");
            name1 = Console.ReadLine();
            Console.Write("Input product quantity : ");
            volume1 = double.Parse(Console.ReadLine());
            Console.Write("Input quantity of goods : ");
            price1 = double.Parse(Console.ReadLine());
            Console.Write("Input number of products : ");
            number1 = double.Parse(Console.ReadLine());

            xaverage1 = price1 / volume1*number1;
            Console.Write("Average volume : {0} baht per unit", xaverage1);


            do
            {
                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("Next product {0}", ++i);

                Console.Write("Input product name : ");
                name2 = Console.ReadLine();
                Console.Write("Input product quantity : ");
                volume2 = double.Parse(Console.ReadLine());
                Console.Write("Input quantity of goods : ");
                price2 = double.Parse(Console.ReadLine());
                Console.Write("Input number of products : ");
                number2 = double.Parse(Console.ReadLine());

                xaverage2 = price2 / volume2*number2;
                Console.Write("Average volume : {0} baht per unit", xaverage2);



                if (xaverage1 < xaverage2)
                {

                }

                else if (xaverage1 > xaverage2)
                {
                    name1 = name2;
                    xaverage1 = xaverage2;
                }

                else if (xaverage1 == xaverage2)
                {
                    name1 = name1 + "," + name2;

                }

                Console.WriteLine();
                Console.WriteLine();

                do
                {
                    Console.Write("Would you like to compare more products? \n Yes or No : ");
                    compare = Console.ReadLine();

                    if (compare != "Yes" && compare != "No")
                    {
                        Console.WriteLine("Yes or No");
                    }

                } while (compare != "Yes" && compare != "No");


                Console.WriteLine();

            } while (compare == "Yes");

            Console.WriteLine(compare);

            Console.WriteLine("The best value product is : {0}", name1);
        }
    }
}
