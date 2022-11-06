using System;
using System.Linq;

namespace LongestIncreasingSubsequence
{
    class Program
    {
        public static void Main()
        {
            int fibunacciNum = int.Parse(Console.ReadLine());
            long[] result = new long[50];
            result[0] = 1;
            result[1] = 1;

            for (int i = 2; i < fibunacciNum; i++)
            {
                result[i] = result[i - 1] + result[i - 2];
            }
            Console.WriteLine(result[fibunacciNum - 1]);
        }
    }
}
