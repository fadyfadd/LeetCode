using System;
namespace LeetCode
{
	public class RemoveDuplicateEntries
	{
	 
            public int RemoveDuplicates(int[] nums)
            {


                int[] temp = new int[nums.Length];

                for (int r = 0; r <= nums.Length - 1; r++)
                    temp[r] = Int32.MinValue;


                int j = 0;

                for (int i = 0; i <= nums.Length - 1; i++)
                {
                    if (!temp.Contains(nums[i]))
                    {
                        temp[j] = nums[i];
                        j++;
                    }

                    for (int s = 0; s <= j - 1; s++)
                    {
                        nums[s] = temp[s];
                    }
                }

                return j;

            }
        
	}
}

