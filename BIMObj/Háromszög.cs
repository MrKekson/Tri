using System;

namespace BIMObj
{
    public static class Háromszög
    {
        public static byte IsTriFound(int[] input)
        {
            if (input.Length < 3) { throw new ArgumentException("Array must be at least 3 element long", input.Length.ToString()); }

            Array.Sort(input);

            var arrSize = input.Length - 1;

            for (int outer = 0; outer < arrSize - 2; outer++)
            {
                for (int inner = outer + 1; inner < arrSize - 1; inner++)
                {
                    for (int scan = inner + 1;
                            scan <= arrSize
                            && input[scan] < (input[inner] + input[outer]);
                            scan++)
                    {
                        if (CheckConstraints(input[outer], input[inner], input[scan]))
                        {
                            return 1;
                        }
                    }
                }
            }

            return 0;
        }

        public static int CountTri1(int[] input)
        {
            var arrSize = input.Length - 1;

            Array.Sort(input);

            var counter = 0;

            for (int i = 0; i < arrSize - 2; ++i)
            {
                for (int j = i + 1; j < arrSize - 1; ++j)
                {
                    for (int k = j + 1; k < arrSize; ++k)
                    {
                        if (CheckConstraints(input[i], input[j], input[k]))
                        {
                            ++counter;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine();

            return counter;
        }

        public static int CountTri2(int[] input)
        {
            if (input.Length < 3) { return -1; }

            Array.Sort(input);

            var arrSize = input.Length - 1;

            var counter = 0;

            for (int outer = 0; outer < arrSize - 2; outer++)
            {
                for (int inner = outer + 1; inner < arrSize - 1; inner++)
                {
                    for (int scan = inner + 1;
                            scan <= arrSize
                            && input[scan] < (input[inner] + input[outer]);
                            scan++)
                    {
                        if (CheckConstraints(input[outer], input[inner], input[scan]))
                        {
                            counter++;
                            break;
                        }
                    }
                }
            }

            return counter;
        }

        public static bool CheckConstraints(int i, int j, int k)
        {
            if (i + j > k
                && j + k > i
                && k + i > j)
            {
                return true;
            }

            return false;
        }
    }
}
