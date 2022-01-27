using System;
using System.Collections.Generic;

namespace Leetcode._2089._Find_Target_Indices_After_Sorting_Array
{
    public class Solution
    {
        public IList<int> TargetIndices(int[] nums, int target)
        {
            var result = new List<int>();
            Array.Sort(nums);
            var start = Array.IndexOf(nums, target);
            while (start < nums.Length && start != -1)
            {
                if(nums[start]==target)
                    result.Add(start++);
                else return result;
            }
            return result;
        }
    }
}