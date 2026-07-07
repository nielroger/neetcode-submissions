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
        

        var dummy = new ListNode();
        int carry = 0;
        var curr = dummy;
        while(l1 != null || l2 != null)
        {
            int val1 = l1 != null ? l1.val : 0;
            int val2 = l2 != null ? l2.val : 0;
            int sum = val1 + val2 + carry;
            curr.next = new ListNode(sum%10);
            carry = sum/10;
            
            if(l1 != null) l1 = l1.next;
            if(l2 != null) l2 = l2.next;
            curr = curr.next;
        }

        if(carry != 0)
        {
            curr.next = new ListNode(carry);
        }
        return dummy.next;
    }
}
