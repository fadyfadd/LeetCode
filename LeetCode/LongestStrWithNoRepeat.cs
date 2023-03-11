using System;
namespace LeetCode
{
	public class LongestStrWithNoRepeat
	{
        public int LengthOfLongestSubstring(string s)
        {
            Dictionary<String, int> lastSeen = new Dictionary<String, int>();
            int start = 0;
            int end = 0;
            String foundString = "";

            while (end <= s.Length - 1)
            {
                String c = s.Substring(end, 1);
                if (lastSeen.ContainsKey(c))
                {
                    String str = s.Substring(start, end - start);

                    if (str.Length > foundString.Length)
                        foundString = str;

                    end = lastSeen[c] + 1;
                    start = lastSeen[c] + 1;

                    lastSeen.Clear();

                }
                else
                {
                    lastSeen.Add(c, end);
                    end = end + 1;
                }
            }

            String str1 = s.Substring(start);

            if (str1.Length > foundString.Length)
                foundString = str1;

            return foundString.Length;
        }
    }
}

