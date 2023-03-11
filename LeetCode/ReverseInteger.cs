using System;
namespace LeetCode
{
	public class ReverseInteger
	{
        public int Reverse(int x)
        {
            Boolean isNegative = false;

            if (x < 0)
            {
                x = x * (-1);
                isNegative = true;
            }
            else
            {
                isNegative = false;
            }

            Int64 cumule = 0;

            while (x > 0)
            {
                cumule = (cumule * 10) + x % 10;
                x = x / 10;
            }

            if (cumule > Int32.MaxValue)
                return 0;
            else
                return (isNegative ? (Int32)cumule * -1 : (Int32)cumule);

        }
    }
}

