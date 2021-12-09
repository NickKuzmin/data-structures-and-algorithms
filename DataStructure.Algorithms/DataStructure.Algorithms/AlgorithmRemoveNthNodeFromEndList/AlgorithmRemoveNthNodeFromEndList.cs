using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Algorithms.AlgorithmRemoveNthNodeFromEndList
{
    public class AlgorithmRemoveNthNodeFromEndList
    {
        public ListNode Execute(ListNode head, int removingElementsCount)
        {
            if (head == null)
                return null;

            var preHead = new ListNode
            {
                Value = -1,
                Next = head
            };

            var slow = preHead;
            var fast = preHead;

            for (var i = 0; i < removingElementsCount; i++)
            {
                fast = fast.Next;
            }

            while (fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next;
            }

            slow.Next = slow.Next.Next;

            return preHead.Next;
        }
    }
}
