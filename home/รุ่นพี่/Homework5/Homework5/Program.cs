using System;

namespace Homework5
{
    class Program
    {
        private static string imageDataFilePath, imageDataString;
        private static int i, j;
        private static double[,] imageDataArray;
        static void Main(string[] args)
        {
            
            string image_data1, convo1, output1;
            double[,] image_data2, convo2;
            

            Console.Write("Imput A :");
            image_data1 = Console.ReadLine();
            Console.Write("Imput B :");
            convo1 = Console.ReadLine();
            Console.Write("Imput C :");
            output1 = Console.ReadLine();


            imageDataFilePath = image_data1;
            ReadImageDataFromFile(imageDataFilePath);
            image_data2 = ReadImageDataFromFile(imageDataFilePath);
            //imagedata2(image_data2);
            int i, j, x, y;
            for (i = 0; i < image_data2.GetLength(0); i++)
            {
                for (j = 0; j < image_data2.GetLength(1); j++)
                {
                    Console.Write(" {0} ", image_data2[i, j]);
                    
                }
                Console.WriteLine();

            }


            imageDataFilePath = convo1;
            ReadImageDataFromFile(imageDataFilePath);
            convo2 = ReadImageDataFromFile(imageDataFilePath);

            imageDataArray = image_data2;
            WriteImageDataToFile(imageDataFilePath, imageDataArray);

        }


        static double[,] ReadImageDataFromFile(string imageDataFilePath)
        {
            string[] lines = System.IO.File.ReadAllLines(imageDataFilePath);
            int imageHeight = lines.Length;
            int imageWidth = lines[0].Split(',').Length;
            double[,] imageDataArray = new double[imageHeight, imageWidth];

            for (int i = 0; i < imageHeight; i++)
            {
                string[] items = lines[i].Split(',');
                for (int j = 0; j < imageWidth; j++)
                {
                    imageDataArray[i, j] = double.Parse(items[j]);
                }
            }
            return imageDataArray;
        }



        static void WriteImageDataToFile(string imageDataFilePath,
                                 double[,] imageDataArray)
        {
            string imageDataString = "";
            for (int i = 0; i < imageDataArray.GetLength(0); i++)
            {
                for (int j = 0; j < imageDataArray.GetLength(1) - 1; j++)
                {
                    imageDataString += imageDataArray[i, j] + ", ";
                }
                imageDataString += imageDataArray[i,
                imageDataArray.GetLength(1) - 1];
                imageDataString += "\n";
            }

            System.IO.File.WriteAllText(imageDataFilePath, imageDataString);
        }


        /*
        static void imagedata2(double[,] image_data2)
        {
            double[,] imageDataArray = image_data2;
            /*
            int i, j,x,y;
            for ( i = 0; i < image_data2.GetLength(0); i++)
            {
                for ( j = 0; j < image_data2.GetLength(1); j++)
                {
                    Console.Write(" {0} ", image_data2[i, j]);
                    imageDataArray = image_data2; 
                }

                
            }
            
            double[,] sum = new double[,] { { image_data2[i, j] }, { image_data2[i, j] }, { image_data2[i, j] }, { image_data2[i, j] }, { image_data2[i, j] }, { image_data2[i, j] }, { image_data2[i, j] }, { image_data2[i, j] } };
            for (x = 0; x < sum.GetLength(0); x++)
            {
                for (y = 0; y < sum.GetLength(1); y++)
                {
                    Console.Write(" {0} ", sum[x, y]);

                }
            }






            */

        }
    
    }


