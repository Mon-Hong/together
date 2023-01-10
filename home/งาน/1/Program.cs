using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*float area, corner , radius;

                        Console.Write(" Input Corner : ");
                        corner = float.Parse(Console.ReadLine());

                        Console.Write(" Input Radius : ");
                        radius = float.Parse(Console.ReadLine());

                        area = (corner / 2) * (radius*radius) ;

                        Console.WriteLine(" Area = " + area );*/


            /* double c, a, b, area;

             Console.Write(" Input c : ");
             c = double.Parse(Console.ReadLine());

             Console.Write(" Input a : ");
             a = double.Parse(Console.ReadLine());

             Console.Write(" Input b : ");
             b = double.Parse(Console.ReadLine());

             area = (0.5 * c) * (a + b);

             Console.WriteLine(" Area = {0}", area);*/


            /*int height;
            Console.Write(" Input Height : ");
            height = int.Parse(Console.ReadLine());

            if (height <= 120 && height > 0)
            {
                Console.WriteLine( " Your ticket price is 250 baht" );
            }
            else if (height <= 0 )
            {
                Console.WriteLine(" Enter new information.");

            }
            else
            {
                Console.WriteLine(" Your ticket price is 350 baht");
            }*/


            string member;
            double price, discount;
            
            Console.Write(" Input your item's price : ");
            price = double.Parse(Console.ReadLine());

            Console.Write(" Are your member : ");
            member= Console.ReadLine();

            if (member == "N")
            {
                Console.WriteLine(" Your product price is {0} baht.", price);
            }

            else if (member == "Y" )
            {
                discount = (price / 100.00) * 10;
                price = (price / 100.00) * 90;
                Console.WriteLine(" You get a discount of {0:f0} baht. \n Your product price is {1:f0} baht.", discount , price);

            }
            else
            {
                Console.WriteLine(" Members only fill in N or Y.");

            }

            Console.ReadLine();
        }
    }
}
