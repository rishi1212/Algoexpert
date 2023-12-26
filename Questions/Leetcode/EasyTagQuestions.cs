using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoexpert.Questions.Leetcode
{
    internal class EasyTagQuestions
    {

        // question 1
        public int[] TwoSum(int[] nums, int target)
        {


            int[] result = { 0, 0 };
            Dictionary<int,int> pairs = new Dictionary<int,int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (pairs.ContainsKey(target - nums[i]))
                {
                    result[0] = pairs[(target - nums[i])];
                    result[1] = i;
                }
                else
                {
                    pairs.TryAdd(nums[i], i);
                }
            }

            return result;

        }
    }
}
