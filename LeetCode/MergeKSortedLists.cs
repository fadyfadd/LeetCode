using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    internal class MergeKSortedLists
    {
        public static ListNode Execute(ListNode[] lists)
        {
            // Base condition
            if (lists == null || lists.Length == 0)
            {
                return null;
            }
            return mergeKLists(lists, 0, lists.Length - 1);
        }

        private static ListNode mergeKLists(ListNode[] lists, int start, int end)
        {
            if (start == end)
            {
                return lists[start];
            }
            // Mid of list of lists
            int mid = start + (end - start) / 2;
            // Recursive call for left sublist
            ListNode left = mergeKLists(lists, start, mid);
            // Recursive call for right sublist
            ListNode right = mergeKLists(lists, mid + 1, end);
            // Merge the left and right sublist
            return merge(left, right);
        }

        private static ListNode merge(ListNode left, ListNode right)
        {
            // Create a dummy node
            ListNode head = new ListNode(-1);
            // Temp node
            ListNode temp = head;
            // Loop until any of the list becomes null
            while (left != null && right != null)
            {
                // Choose the value from the left and right which is smaller
                if (left.val < right.val)
                {
                    temp.next = left;
                    left = left.next;
                }
                else
                {
                    temp.next = right;
                    right = right.next;
                }
                temp = temp.next;
            }
            // Take all nodes from left list if remaining
            while (left != null)
            {
                temp.next = left;
                left = left.next;
                temp = temp.next;
            }
            // Take all nodes from right list if remaining
            while (right != null)
            {
                temp.next = right;
                right = right.next;
                temp = temp.next;
            }
            return head.next;
        }


    }
}
