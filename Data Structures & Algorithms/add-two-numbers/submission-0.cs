/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        

        int carry = 0;
        var dummy = new ListNode();
        var prev = dummy;

        while(l1 != null || l2 != null)
        {
            int val1 = l1 == null ? 0 : l1.val;
            int val2 = l2 == null ? 0 : l2.val;

            int sum = val1 + val2 + carry;
            var newNode = new ListNode(sum%10);
            carry = sum/10;
            prev.next = newNode;
            prev = prev.next;

            if(l1 != null) l1 = l1.next;
            if(l2 != null) l2 = l2.next;
        }

        if(carry > 0)
            prev.next = new ListNode(carry);
        return dummy.next;
    }
}
