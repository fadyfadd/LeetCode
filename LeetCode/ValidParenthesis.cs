using System;
namespace LeetCode
{
	public class ValidParenthesis
	{
        public bool IsValid(string s)
        {

            Stack<String> stk = new Stack<String>();
            Dictionary<String, String> dic = new Dictionary<String, String>();

            dic.Add("]", "[");
            dic.Add(")", "(");
            dic.Add("}", "{");

            for (int i = 0; i <= s.Count() - 1; i++)
            {
                String k = s.Substring(i, 1);

                if (k == "(" || k == "[" || k == "{")
                    stk.Push(k);

                if (k == "]" || k == ")" || k == "}")
                {
                    if (stk.Count() == 0)
                        return false;

                    var v = stk.Pop();
                    if (v != dic[k])
                        return false;
                }

            }

            return stk.Count() == 0;
        }
    }
}

