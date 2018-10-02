using System;
using System.Collections.Generic;
using System.Text;

namespace BIMObj
{
    public static class Háromszög
    {
        public static byte IsContainsTri1(int[] input)
        {
            var arrSize = input.Length -1;

            for (int leftSide = 0; leftSide < arrSize - 2; leftSide++)
            {
                for (int rightSide = arrSize; rightSide > leftSide + 1; rightSide--)
                {
                    for (int middle = leftSide + 1; middle < rightSide; middle++)
                    {
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

        public static byte IsContainsTri2(int[] input)
        {
            if (input.Length < 3) { return 255; };

            Array.Sort(input);
            var arrSize = input.Length - 1;

            int midPoint = arrSize / 2;

            //bool midFloatBool;
            //int midFloatDiff;

            Console.WriteLine($"{ input.Length} .. { arrSize}");

            for (int outer = 0; outer < arrSize - 2; outer++)
            {

                for (int inner = outer + 1; inner < arrSize -1; inner++)
                {
                    for (int scan = inner + 1; input[scan] < (input[inner] + input[outer] - 1); scan++)
                    {
                        if (CheckConstraints(input[outer], input[inner], input[scan]))
                        {
                            Console.WriteLine($"Found2: {input[outer]},{input[inner]},{input[scan]}");
                            return 1;
                        }
                    }


                }

            }




            return 0;
        }

        private static int maxValid(int a, int b)
        {
            return a + b - 1;
        }

        private static int minValid(int a,int b)
        {
            //TODO: sorozatnál kell az if?
            if(a > b)
            { return a - b + 1;  }
            else
            { return b - a + 1; }
        }

        public static bool CheckConstraints(int i, int j, int k)
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
