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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        if (list1 == null) return list2;
        if (list2 == null) return list1;

        ListNode dummy = new ListNode(0);
        ListNode current = dummy;
        while(list1 !=null && list2 != null)
        {
            if(list2.val <= list1.val)
            {
                current.next = list2;
                list2 = list2.next;
            }
            else
            {
                current.next = list1;
                list1 = list1.next;
            }
            current = current.next;
        }
        if(list1 != null) current.next = list1;
        if(list2 != null) current.next = list2;

        return dummy.next;
    }
}