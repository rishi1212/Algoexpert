using System;

namespace Algoexpert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] array = { -1, -2, 3, 4, -5, 6,-9 };
            int[] answer = new int[array.Length];
            int[] sortedSquares = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                answer[i] = Math.Abs(array[i]);
            }
            Array.Sort(answer);
            for (int i = 0; i < array.Length; i++)
            {
                sortedSquares[i] = answer[i] * answer[i];
            }

        }
    }
}
