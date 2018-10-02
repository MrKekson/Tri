using System;
using System.Collections.Generic;
using System.Text;

namespace BIMObj
{
    public static class Helper
    {
        public static void Help()
        {
            SrcThird(10, 18);

            SrcThird(9, 18);
            SrcThird(10, 17);

            SrcThird(4, 25);
            SrcThird(3, 25);

            for (int i = 4; i < 9; i+=2)
            {
                SrcThird(5, i);

            }


            /*SrcThird(21, 25);
            SrcThird(22, 25);
            SrcThird(23, 25);
            SrcThird(22, 24);
            SrcThird(22, 25);
            SrcThird(22, 26);

            SrcThird(-9, 18);
            SrcThird(-9, 9);
            SrcThird(-18, -9);*/
        }



        public static void SrcThird(int a, int b)
        {
            Console.WriteLine($"Set {a}, {b}:");

            var min = Math.Min(a, b);
            var max = Math.Max(a, b);
            var tempNum = 0;
            Console.Write($"-->");
            for (int i = min - min; i < max + max; i++)
            {
                if (Háromszög.CheckConstraints(a, i, b))
                {
                    Console.Write($" {i},");
                }
                tempNum = i;
            }
            Console.WriteLine();
            Console.WriteLine($"||Start :{min-min} Last {tempNum}");
            Console.WriteLine();
        }
    }
}
