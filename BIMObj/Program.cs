using System;

namespace BIMObj
{
    class Program
    {
        static int[] input = new int[] { 10, 2, 5, 1, 8, 20 };
 

        static void Main(string[] args)
        {
            Console.WriteLine($"Returned {Háromszög.IsContainsTri(input)}");
            Console.Read();
        }
    }
}
