using System;
namespace LeetCode
{
	public class LonguestCommonPfx
	{
        public string LongestCommonPrefix(string[] strs)
        {

            if (strs.Length == 1)
                return strs[0];

            Array.Sort(strs);

            int i = 0;
            String result = "";

            var head = strs[0];
            var tail = strs[strs.Length - 1];


            while (i <= head.Length - 1 && i <= tail.Length - 1 && head[i] == tail[i])
            {
                result = result + head[i];
                i++;
            }



            return result;
        }
    }
}

