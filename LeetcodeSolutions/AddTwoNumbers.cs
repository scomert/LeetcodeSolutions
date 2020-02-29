using System;

namespace LeetcodeSolutions
{
    public class AddTwoNumbers
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x)
            {
                val = x;
            }
        }
        public ListNode SolveAddTwoNumbers(ListNode l1, ListNode l2)
        {
            int carry = 0;
            var resultNode = new ListNode(0);
            var head = resultNode;

            while (!(l1 == null && l2 == null))
            {
                var l1Value = l1 == null ? 0 : l1.val;
                var l2Value = l2 == null ? 0 : l2.val;
                var sum = l1Value + l2Value + carry;
                var nodeValue = sum % 10;
                carry = sum / 10;

                resultNode.next = new ListNode(nodeValue);
                resultNode = resultNode.next;

                l1 = l1?.next;
                l2 = l2?.next;
            }

            if (carry > 0)
            {
                resultNode.next = new ListNode(carry);
            }

            return head.next;
        }
    }
}
