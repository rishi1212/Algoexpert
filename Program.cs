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
            int largest = answer[0];
            int smallest = answer[0];
            for (int i = 0; i < array.Length; i++)
            {
                answer[i] = Math.Abs(array[i]);
            }
            foreach (int item in answer)
            {
                
            }
        }
    }
}
