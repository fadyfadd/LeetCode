using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class PrintFibonacci
    {
            public static List<Int32> Execute(int x)
            {
                List<int> result = new List<int>();

                int a = 0;
                int b = 1;
                result.Add(0);
                result.Add(1);

                int sum = 1; 

                for (int i = 1 ; i <= x - 2 ; i++)
                {
                    result.Add(sum);
                    a = b;
                    b = sum;               
                    sum = a + b; 
                }           

                return result; 
            }
    }
}
    