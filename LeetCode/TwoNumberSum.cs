using System;
namespace LeetCode
{
	public class TwoNumberSum
	{
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<Int32, Int32> lookup = new Dictionary<int, int>();

            for (int i = 0; i <= nums.Length - 1; i++)
            {
                int diff = target - nums[i];

                if (lookup.ContainsKey(diff))
                {
                    return new int[] { i, lookup[diff] };
                }
                else
                {
                    if (!lookup.ContainsKey(nums[i]))
                        lookup.Add(nums[i], i);
                }
            }
            return null;
        }

    }
}

	