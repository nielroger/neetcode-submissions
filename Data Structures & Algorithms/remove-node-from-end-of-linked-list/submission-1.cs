public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        
        if(head == null) return head;
        var fast = head;
        int index = 0;
        while(fast != null && index < n )
        {
            fast = fast.next;
            index++;
        }
        
        
        if(fast == null)
        {
            return head.next;
        }

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