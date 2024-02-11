using Algoexpert.Questions;
using Algoexpert.Questions.Leetcode;
using System;
using System.Linq;

namespace Algoexpert
{
    class Program
    {
        // to change 
        static void Main(string[] args)
        {
            EasyTagQuestions obj = new EasyTagQuestions();
            int[] answer = obj.TwoSum([2,7,11,15],9);
            foreach (int i in answer)
            {
                Console.WriteLine(i);
            }

        }
    }
}
