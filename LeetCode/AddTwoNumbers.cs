using System;
namespace LeetCode
{
	public class AddTwoNbrs
	{
        public String AddTwoStrings(String a, String b)
        {
            Console.WriteLine(a);
            Console.WriteLine(b);
            Stack<String> stk = new Stack<string>();

            int l = Math.Max(a.Length, b.Length);
            var v1 = a.PadLeft(l, '0');
            var v2 = b.PadLeft(l, '0');
            int retenue = 0;

            for (int i = v1.Length - 1; i >= 0; i--)
            {
                string a1 = v1.Substring(i, 1);
                string a2 = v2.Substring(i, 1);

                Int32 v = Convert.ToInt32(a1) + Convert.ToInt32(a2) + retenue;

                if (v < 10)
                {
                    stk.Push(v.ToString());
                    retenue = 0;
                }
                else
                {
                    stk.Push(v.ToString().Substring(1, 1));
                    retenue = 1;
                }

            }

            if (retenue == 1)
                stk.Push("1");

            String f = "";

            while (stk.Count != 0)
            {
                f += stk.Pop();

            }
            Console.WriteLine(f);
            return f;
        }

        private ListNode ToListofNodes(IEnumerable<char> chars)
        {

            ListNode header = new ListNode();
            ListNode temp = header;

            foreach (var c in chars)
            {

                ListNode node = new ListNode();
                node.val = Convert.ToInt32(c.ToString());
                temp.next = node;
                temp = node;
            }

            return header.next;
        }

        private String GetNumber(ListNode l1)
        {

            List<String> lst = new List<String>();

            while (l1 != null)
            {
                lst.Add(Convert.ToString(l1.val));
                l1 = l1.next;
            }

            lst.Reverse();
            var value = lst.Aggregate((a, b) => a + b);
            return value;
        }

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {

            var v1 = GetNumber(l1);
            var v2 = GetNumber(l2);

            var v3 = AddTwoStrings(v1, v2);
            IEnumerable<char> chars = v3.Reverse();
            return ToListofNodes(chars);

        }
    }
}

