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
    public void ReorderList(ListNode head) {
        if (head == null || head.next == null) return;
        var slow = head;
        var fast = head;

        while(fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        var currHead = slow.next;
        slow.next = null;
        var second = Reverse(currHead);

        var first = head;
        while(second != null)
        {
            var tmp1 = first.next;
            var tmp2 = second.next;
            
            first.next = second;
            second.next = tmp1;
            
            first = tmp1;
            second = tmp2;
        }

    }

    public ListNode Reverse(ListNode head)
    {
        ListNode prev = null;
        var curr = head;

        while(curr != null)
        {
            var next = curr.next;
            curr.next = prev;
            prev = curr;
            curr = next;
        }

        return prev;
    }
}