using System;

namespace First_week
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            n = (Math.Pow(x,y))+z;
            n = Math.Abs( (x + 2 ) * Math.Log( 5,10 ) );
            n = Math.Sqrt(Math.Cos(Math.PI));
            n = Math.Pow( 16 , 0.25 );


            */

            /*
            int ded, sor, n;

            Console.Write(" Input divided : ");
            ded = int.Parse(Console.ReadLine());

            Console.Write(" Input divisor : ");
            sor = int.Parse(Console.ReadLine());

            n = ded % sor;

            Console.WriteLine("Quotitnent of {0}/{1} is {2} and remainder is {3}." ,ded , sor ,ded/sor ,n);
            */
            /*
            double Celsius , Fahrenheit;

            Console.Write(" Input Temperature in degrees Celsius : ");
            Celsius = double.Parse(Console.ReadLine());

            Fahrenheit = (9.0 / 5.0) * Celsius + 32;

            Console.WriteLine("{0} degrees Celsius is equivalent to {1} degrees Fahrenheit ", Celsius, Fahrenheit);
            */

            /*
            double a, b, c, num1 , num2;
            Console.Write(" input a :");
            a = double.Parse(Console.ReadLine());
            Console.Write(" input b :");
            b = double.Parse(Console.ReadLine());

            Console.Write(" input c :");
            c = double.Parse(Console.ReadLine());

            num1 = (-b + Math.Sqrt((Math.Pow(b, 2)) - (4 * a * c))) / (2 * a);
            num2 = (-b - Math.Sqrt((Math.Pow(b, 2)) - (4 * a * c))) / (2 * a);

            Console.WriteLine(" The answers of equation is {0:f2} and {1:f2} " , num1 , num2);
            */

            double x, y, z, perimeter;
            Console.Write(" Input X :");
            x = double.Parse(Console.ReadLine());
            Console.Write(" Input Y :");
            y = double.Parse(Console.ReadLine());
            z = Math.Sqrt(Math.Pow(x,2)+ Math.Pow(y,2));
            perimeter = x + y + z;
            Console.WriteLine(" The length of Z : {0:f3} \n The length of perimeter is {1}" , z , perimeter);

            Console.ReadLine();
        }
    }
}
