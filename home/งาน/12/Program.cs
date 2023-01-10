using System;

namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum=0,avg=0;

            double[,] score = new double[4, 2]
            {
                {3,8},{ 6,7},{ 8,10},{ 9,7}
            };

            /* for (int i =0; i< score.GetLength(0); i++)
            {
                for (int j = 0; j < score.GetLength(1); j++)
                {
                     sum += score[i, j];
                }

            }
            Console.WriteLine(sum);

             */
            /*
            for (int i = 0; i < score.GetLength(0); i++)
            {
                for (int j = 0; j < score.GetLength(1); j++)
                {
                    sum = sum + score[i, 0];
                }
                avg = sum / score.GetLength(0);                
            }
            Console.WriteLine(avg);
            */

            for (int i = 0; i < score.GetLength(0); i++)
            {
                for (int j = 0; j < score.GetLength(1); j++)
                {
                    sum = score[3, 0] + score[3, 1];
                }
                avg = sum / 2;
            }
            Console.WriteLine(avg);

        }
    }
}
