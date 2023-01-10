using System;

namespace Method_CalDisandSlope
{
    class Program
    {
        private static double x1, y1, x2, y2, dist, slope;

        static void Main(string[] args)
        {
            Console.Write("Input X1 : ");
            x1 = double.Parse(Console.ReadLine());
            Console.Write("Input Y1 : ");
            y1 = double.Parse(Console.ReadLine());
            Console.Write("Input X2 : ");
            x2 = double.Parse(Console.ReadLine());
            Console.Write("Input Y2 : ");
            y2 = double.Parse(Console.ReadLine());

            CAL(x1, y1, x2, y2, out dist, out slope);

            Console.WriteLine("Dist = {0} and Slope = {1}" , dist ,slope);
        }

        static void CAL(double x1, double y1, double x2, double y2, out double dist, out double slope)
        {
            dist = Math.Sqrt((Math.Pow(x2 - x1, 2.00)) + (Math.Pow(y2 - y1, 2.00)));

            slope = (y2 - y1) / (x2 - x1); 
        }

    }
}   
