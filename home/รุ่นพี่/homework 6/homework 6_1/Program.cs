using System;

namespace homework_6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu , level_s, numProblem, answer ;
            double score1 = 0,  score2;
            Difficulty level = Difficulty.Easy;
            long time1, time2, time3;

            do
            {
                double level_score = 0, num = 0,cheap = 0;

                Console.WriteLine("Score: {0}, Difficulty: {1} ", score1, level);
                Console.WriteLine("\n >>>> Menu <<<< \n 0 = Play Game \n 1 = Set level \n 2 = exit");

                do
                {
                    Console.Write("Input : ");
                    menu = int.Parse(Console.ReadLine());
                    if(menu != 0 && menu != 1 && menu != 2)
                    {
                        Console.WriteLine(" Please input 0 - 2.");
                    }
                } while (menu != 0 && menu != 1 && menu != 2);

                if(menu == 0)
                {

                    Console.WriteLine("\n>- Play Game -<");

                    time1 = DateTimeOffset.Now.ToUnixTimeSeconds();


                    if (level == Difficulty.Easy)
                    {

                    }

                        if (level == Difficulty.Easy)
                    {
                        numProblem = 3;
                        for (int i = 0; i < 3; i++)
                        {
                            GenerateRandomProblems(numProblem);
                            Problem[] random = GenerateRandomProblems(numProblem);
                            
                            Console.WriteLine(random[i].Message);
                            Console.Write("Your answer : ");
                            answer = int.Parse(Console.ReadLine());
                            if (answer == random[i].Answer)
                            {
                                cheap = cheap + 1;
                                
                            }
                            num = 3.000;
                            level_score = 0.000;
                        }
                        
                    }

                    else if(level == Difficulty.Normal)
                    {
                        numProblem = 5;
                        for (int i = 0; i < 5; i++)
                        {
                            GenerateRandomProblems(numProblem);
                            Problem[] random = GenerateRandomProblems(numProblem);

                            Console.WriteLine(random[i].Message);
                            Console.Write("Your answer : ");
                            answer = int.Parse(Console.ReadLine());
                            if (answer == random[i].Answer)
                            {
                                cheap = cheap + 1;
                                
                            }
                            num = 5;
                            level_score = 1;
                        }
                        
                    }

                    else if(level == Difficulty.Hard)
                    {
                        numProblem = 7;
                        for (int i = 0; i < 7; i++)
                        {
                            GenerateRandomProblems(numProblem);
                            Problem[] random = GenerateRandomProblems(numProblem);

                            Console.WriteLine(random[i].Message);
                            Console.Write("Your answer : ");
                            answer = int.Parse(Console.ReadLine());
                            if (answer == random[i].Answer)
                            {
                                cheap = cheap + 1;
                                
                            }
                            num = 7;
                            level_score = 2;
                        }
                        
                    }

                    time2 = DateTimeOffset.Now.ToUnixTimeSeconds();
                    time3 = time2 - time1;

                    Console.WriteLine("Time spent doing {0} seconds. ",time3);
                    Console.WriteLine("correct {0}", cheap);
                    
                    score2 = (cheap / num) * ((25 - Math.Pow( level_score ,2)) / Math.Max(time3, (25 - Math.Pow(level_score, 2)))) * (Math.Pow((2 * level_score) + 1,2)) ;
                    Console.WriteLine("Score : {0}",score2);
                    score1 = score1 + score2;
                }
                

                if (menu == 1)
                {
                    do
                    {
                        Console.WriteLine("\n >- Set level -< \n 0 = Easy \n 1 = Normal \n 2 = Hard");
                        Console.Write("Input level : ");
                        level_s = int.Parse(Console.ReadLine());

                        if (level_s == 0)
                        {
                            level = Difficulty.Easy;
                        }
                        else if (level_s == 1)
                        {
                            level = Difficulty.Normal;
                        }
                        else if (level_s == 2)
                        {
                            level = Difficulty.Hard;
                        }
                        else
                        {
                            Console.WriteLine("Please input 0 - 2.");
                        }

                    } while (level_s != 0 && level_s != 1 && level_s != 2);
                }


                Console.WriteLine("\n\n");
            } while (menu != 2);

            Console.WriteLine("**********************\n----- exit game ------\n**********************");


        }


        enum Difficulty
        {
            Easy,
            Normal,
            Hard
        }



        struct Problem
        {
            public string Message;
            public int Answer;

            public Problem(string message, int answer)
            {
                Message = message;
                Answer = answer;
            }
        }




        static Problem[] GenerateRandomProblems(int numProblem)
        {
            Problem[] randomProblems = new Problem[numProblem];

            Random rnd = new Random();
            int x, y;

            for (int i = 0; i < numProblem; i++)
            {
                x = rnd.Next(50);
                y = rnd.Next(50);
                if (rnd.NextDouble() >= 0.5)
                    randomProblems[i] =
                    new Problem(String.Format("{0} + {1} = ?", x, y), x + y);
                else
                    randomProblems[i] =
                    new Problem(String.Format("{0} - {1} = ?", x, y), x - y);
            }

            return randomProblems;
        }



    }
}
