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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        
        if(n == 0) return head;

        int i = 0;
        var fast = head;
        while( i < n)
        {
            fast = fast.next;
            i++;            
        }

        if (fast == null) return head.next;

        var slow = head;
        while(fast.next != null)
        {
            slow = slow.next;
            fast = fast.next;
        }

        slow.next = slow.next.next;

        return head;
    }
}
