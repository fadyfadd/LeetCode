using System;
namespace LeetCode
{
	public class PalindormeNumber
	{
        public bool IsPalindrome(int x)
        {
            var arr = x.ToString().ToCharArray();
            int i = 0;
            int j = arr.Length - 1;
            String result = "";

            while (i < j)
            {
                char temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                i++;
                j--;
            }

            for (int k = 0; k <= arr.Length - 1; k++)
            {
                result += arr[k];
            }

            return x.ToString() == result;
        }
    }
}

