using System;
using System.Collections.Generic;
using System.Linq;

namespace BIMObj
{
    class Program
    {
        static int[] input = new int[] { 10, 2, 5, 1, 8, 20 };
        static int[] input2 = new int[] { 10, 50, 5 ,1 };

        static void Main(string[] args)
        {
            Console.WriteLine(Háromszög.IsTriFound(input));
            Console.WriteLine(Háromszög.IsTriFound(input2));

            //SingleRunPerfTest();
            Console.Write("Done. Press [enter] to exit.");
            Console.Read();
        }

        private static void SingleRunPerfTest()
        {
            var start = DateTime.Now;
            var data = new List<int>();

            var rndGen = new Random();

            var tmp = 0;

            for (int i = 0; i < 30000; i++)
            {
                tmp += rndGen.Next(1, 10);
                data.Add(tmp);
            }
            LogTime(ref start);
            Console.WriteLine($"Found {Háromszög.CountTri1(data.ToArray())} tris with O(n3)");
            LogTime(ref start);
            Console.WriteLine($"Found {Háromszög.CountTri2(data.ToArray())} tris with optimized O(n3)");
            LogTime(ref start);
        }

        private static void LogTime(ref DateTime prevTime)
        {
            var outTime = DateTime.Now - prevTime;
            Console.WriteLine($"---- Time: {outTime.TotalSeconds} ----");
            prevTime = DateTime.Now;
        }

    }

   
}
