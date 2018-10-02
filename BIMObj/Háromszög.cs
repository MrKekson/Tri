using System;
using System.Collections.Generic;
using System.Text;

namespace BIMObj
{
    public static class Háromszög
    {
        public static byte IsContainsTri(int[] input)
        {
            var arrSize = input.Length -1;

            for (int leftSide = 0; leftSide < arrSize - 2; leftSide++)
            {
                for (int rightSide = arrSize; rightSide > leftSide + 1; rightSide--)
                {
                    for (int middle = leftSide + 1; middle < rightSide; middle++)
                    {
                        Console.WriteLine($"Rota: {input[leftSide]},{input[rightSide]},{input[middle]}");
                        if (CheckConstraints(input[leftSide], input[rightSide], input[middle]))
                        {
                            Console.WriteLine($"Found: {input[leftSide]},{input[rightSide]},{input[middle]}");
                            return 1;
                        }
                    }
                }
            }

            return 0;
        }

        private static bool CheckConstraints(int i, int j, int k)
        {
            if ( i+j > k 
                && j+k > i 
                && k+i > j)
            {
                return true;
            }

            return false;
        }
    }
}
