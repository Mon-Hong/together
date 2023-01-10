using System;

namespace sss
{
    class Program
    {
        static void Main(string[] args)
        {  /* Math.Sqrt รากที่2
                Math.Abs สมบูรณ์
                Math.Round ปักทศนิยม
                Math.Ceiling ปัดขึ้น
                Math.Floor ปัดลง
                Math.Pow ยกกำลัง
                Math.Log เลขฐาน
                Math.PI พาย
            */


            int i = 0, j = 0, k = 0;
            for (i = 1; i <= 5; i++)
                for (k = 1; k <= i; k++)
                    if (i % k == 0)
                        j = j + k;
            Console.WriteLine("{0}", j);

            Console.WriteLine(6 + 10 * 2 - 2 * 3);

            Console.WriteLine(7 / 4 * 8 + 4 * 3);

            Console.WriteLine(5 / 3 * 3 / 5 + 3 + 4 * 4);




            Console.ReadLine();
        }
    }
}
