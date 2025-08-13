using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;

namespace CodingStuff
{

    class LeetCode
    {
        public IList<int> InorderTraversal(TreeNode root)
        {
            ThreeNode current = root;
            return null;
        }
        public bool Exist(char[][] board, string word)
        {

            return false;
        }
        public bool palindrome(int num)
        {
            int revNum = 0;
            int n = num;
            while (n > 0)
            {
                revNum = revNum * 10 + n % 10;
                n = n / 10;
            }

            if (revNum == num)
            {
                return true;
            }
            return false;
        }
        public ListNode addTwo(ListNode l1, ListNode l2)
        {
            ListNode sum = listNodeSum(l1, l2, 0);
            return sum;
        }

        public ListNode listNodeSum(ListNode node1, ListNode node2, int remainder)
        {
            if (node1 != null || node2 != null || remainder == 1)
            {
                int currentSum = remainder;

                if (node1 != null)
                {
                    currentSum += node1.val;
                    node1 = node1.next;
                }

                if (node2 != null)
                {
                    currentSum += node2.val;
                    node2 = node2.next;
                }

                if (currentSum % 10 < currentSum)
                {
                    currentSum = currentSum % 10;
                    return new ListNode(currentSum, listNodeSum(node1, node2, 1));
                }

                return new ListNode(currentSum, listNodeSum(node1, node2, 0));
            }
            return null;
        }

    }
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

}