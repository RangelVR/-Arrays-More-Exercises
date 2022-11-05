using System;
using System.Linq;

namespace _01._Encrypt__Sort_and_Print_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] output = new int[n];

            for (int i = 0; i < n; i++)
            {
                string inputString = Console.ReadLine();
                int sum = 0;
                foreach (var ch in inputString)
                {
                    switch (ch)
                    {
                        case 'a':
                        case 'e':
                        case 'i':
                        case 'o':
                        case 'u':
                        case 'A':
                        case 'E':
                        case 'I':
                        case 'O':
                        case 'U':
                            sum += ch * inputString.Length;
                            break;
                        default:
                            sum += ch / inputString.Length;
                            break;
                    }
                }
                output[i] = sum;
            }
            foreach (var item in output.OrderBy(x => x))
            {
                Console.WriteLine(item);
            }
            //Array.Sort(output);
            //foreach (var item in output)
            //{
            //    Console.WriteLine(item);
            //}

        }
    }
}
