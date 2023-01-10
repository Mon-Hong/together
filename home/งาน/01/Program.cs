using System;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {

            /* double a, b, c, num1, num2;

             Console.Write(" Input a : ");
             a = double.Parse(Console.ReadLine());

             Console.Write(" Input b : ");
             b = double.Parse(Console.ReadLine());

             Console.Write(" Input c : ");
             c = double.Parse(Console.ReadLine());

             num1 = (-b + Math.Sqrt((Math.Pow(b, 2)) - (4 * a * c))) / (2 * a);
             num2 = (-b - Math.Sqrt((Math.Pow(b, 2)) - (4 * a * c))) / (2 * a);



             Console.WriteLine("{0:f2} , {1:f2}" , num1 , num2); */

            int password, ci1, ci2, ci3, fb1, fb2, fb3, ns1, ns2, ns3, ns4, ns5, ns6, ns7, ns8;
            string org;

            password = 1;
            Console.WriteLine("if you want to stop testing insert password = 0");
            while (password != 0)
            {
                Console.WriteLine("  ");
                Console.Write("Insert your password : ");
                password = int.Parse(Console.ReadLine());

                if (password == 0)
                {
                    Console.Write("Thanks");
                    break;
                }

                Console.Write("Insert your Organization : ");
                org = Console.ReadLine();

                if (org == "CIA") // รับค่า org 3 แบบแล้วตามด้วย else ถ้าไม่ตรง 3 แบบ
                {
                    ci1 = password % 10;
                    if (ci1 % 3 == 0)
                    {
                        ci2 = password / 10; // 12703.9 (% หาหลักหน่วย
                                             // Console.WriteLine("{0} , {1}" , ci1 ,ci2); (เทสๆ)
                        if (ci2 % 10 != 1 && ci2 % 10 != 3 && ci2 % 10 != 5)
                        {
                            ci3 = password / 1000;
                            if (ci3 % 10 == 6 && ci3 % 10 == 7)
                            {
                                Console.WriteLine(true);

                            }
                            else
                                Console.WriteLine(false);

                        }
                        else
                            Console.WriteLine(false);

                    }
                    else
                        Console.WriteLine(false);

                }

                if (org == "FBI")
                {
                    fb1 = password / 100000;
                    if (fb1 % 10 == 4 || fb1 % 10 == 5 || fb1 % 10 == 6 || fb1 % 10 == 7)
                    {
                        fb2 = password / 100;
                        if (fb2 % 10 == 2 || fb2 % 10 == 4 || fb2 % 10 == 8)
                        {
                            fb3 = password / 10000;
                            if (fb3 % 2 == 1 || fb3 == 1)
                            {
                                Console.WriteLine(true);

                            }
                            else
                                Console.WriteLine(false);

                        }
                        else
                            Console.WriteLine(false);

                    }
                    else
                        Console.WriteLine(false);

                }

                if (org == "NSA")
                {
                    ns1 = password % 10;
                    if (ns1 == 1 || ns1 == 2 || ns1 == 3 || ns1 == 5 || ns1 == 6)
                    {
                        ns2 = password / 100;
                        if (ns2 % 3 == 0 || ns2 % 2 != 0)
                        {
                            ns3 = password / 100000;
                            ns4 = password / 10000;
                            ns5 = password / 1000;
                            ns6 = password / 100;
                            ns7 = password / 10;
                            ns8 = password / 1;
                            if (ns3 % 10 == 7 || ns4 % 10 == 7 || ns5 % 10 == 7 || ns6 % 10 == 7 || ns7 % 10 == 7 || ns8 % 10 == 7)
                            {
                                Console.WriteLine(true);

                            }

                            else
                                Console.WriteLine(false);

                        }

                        else
                            Console.WriteLine(false);

                    }
                    else
                        Console.WriteLine(false);

                }
                if (org != "CIA" && org != "FBI" && org != "NSA")
                {
                    Console.WriteLine(false);
                }

            }


            Console.ReadLine();
        }
    }
}
