using System;

namespace BIMObj
{
    class Program
    {
        static int[] input = new int[] { 10, 2, 5, 1, 8, 20 };
        static int[] orderedInput = new int[] { 1, 2, 5, 8, 10, 20 };

        static void Main(string[] args)
        {
            Helper.Help();




            Helper.SrcThird(2, 7);
            Console.WriteLine($"Returned {Háromszög.IsContainsTri1(orderedInput)}");
            Console.WriteLine($"Returned {Háromszög.IsContainsTri2(input)}");
            Console.Read();
        }

        
    }
}
