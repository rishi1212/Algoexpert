using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Algoexpert.Questions
{
    internal class SortedSquaredArray
    {
         public void SortedSquaredArrayCode() {
            int[] array = { -1, -2, 3, 4, -5, 6, -9 };
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

        public void SortedSquareArrayCodeNew(int[] array) {
            int[] sortedSquares = new int[array.Length];
            int smallerValueIdx = 0;
            int largerValueIdx = array.Length - 1;
            for(int idx = array.Length - 1; idx >= 0; idx--)
            {
                int smallerValue = array[smallerValueIdx];
                int largerValue = array[largerValueIdx];
                if(Math.Abs(smallerValue) > Math.Abs(largerValue))
                {

                }
            }
        }
    }
}
