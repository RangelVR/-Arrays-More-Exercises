using System;
using System.Linq;

namespace _03._Recursive_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mainArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] arr1 = new int[mainArr.Length / 2];
            int[] arr2 = new int[mainArr.Length / 2];
            int[] result = new int[mainArr.Length / 2];

            for (int i = 0; i < mainArr.Length / 2; i++)
            {
                arr1[i] = mainArr[i];
                arr2[i] = mainArr[(mainArr.Length / 2) + i];
            }
            for (int k = 0; k < arr1.Length / 2; k++)
            {
                result[k] = arr1[((arr1.Length / 2) - 1) - k] + arr1[(arr1.Length / 2) + k];
                result[(arr1.Length / 2) + k] = arr2[k] + arr2[(arr2.Length - 1) - k];
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
