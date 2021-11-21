using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Algorithms.AddTwoNumbers
{
    /// <summary>
    /// https://leetcode.com/problems/add-two-numbers/
    /// You are given two non-empty linked lists representing two non-negative integers.
    /// The digits are stored in reverse order, and each of their nodes contains a single digit.
    /// Add the two numbers and return the sum as a linked list.
    /// You may assume the two numbers do not contain any leading zero, except the number 0 itself.
    /// 
    /// Цифры числа хранятся в обратном порядке и нужно их складывать: 342 (2-4-3) + 465 (5-6-4) = 807 (7-0-8)
    /// 
    /// Example 1:
    /// Input: l1 = [2,4,3], l2 = [5,6,4]
    /// Output: [7,0,8]
    /// Explanation: 342 + 465 = 807.
    /// 
    /// Example 2:
    /// Input: l1 = [0], l2 = [0]
    /// Output: [0]
    /// 
    /// Example 3:
    /// Input: l1 = [9,9,9,9,9,9,9], l2 = [9,9,9,9]
    /// Output: [8,9,9,9,0,0,0,1]
    /// 
    /// Constraints:
    /// The number of nodes in each linked list is in the range[1, 100].
    /// 0 <= Node.val <= 9
    /// It is guaranteed that the list represents a number that does not have leading zeros.
    /// </summary>
    public class AlgorithmAddTwoNumbers
    {
        // Definition for singly-linked list.
        public class ListNode {
            public int Value { get; set; }

            public ListNode Next { get; set; }

            public ListNode(int val = 0, ListNode next = null) {
                Value = val;
                Next = next;
            }
        }

        public ListNode Execute(ListNode node1, ListNode node)
        {
            if (node1 == null && node == null) return null;

            ListNode previousNode = new ListNode(-1);
            ListNode currentNode = previousNode;
            ListNode previousNode1 = node1;
            ListNode previousNode2 = node;
            int carry = 0;
            while (previousNode1 != null || previousNode2 != null || carry > 0)
            {
                int value = 0;
                if (previousNode1 != null)
                {
                    value += previousNode1.Value;
                    previousNode1 = previousNode1.Next;
                }

                if (previousNode2 != null)
                {
                    value += previousNode2.Value;
                    previousNode2 = previousNode2.Next;
                }

                value += carry;

                carry = value / 10;
                value = value % 10;

                ListNode temp = new ListNode(value);

                currentNode.Next = temp;
                currentNode = temp;

            }

            return previousNode.Next;
        }
    }
}
