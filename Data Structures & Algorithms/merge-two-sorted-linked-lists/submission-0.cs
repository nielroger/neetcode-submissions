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
        
        var dummy = new ListNode();    
        var newNode = new ListNode();
        dummy = newNode;
        var curr1 = list1;
        var curr2 = list2;

        while(curr1 != null && curr2 != null)
        {
            if(curr1.val < curr2.val)
            {
                newNode.next = curr1;
                curr1 = curr1.next;
            }
            else
            {
                newNode.next = curr2;
                curr2 = curr2.next;
            }
            newNode = newNode.next;
        }

        if(curr1 != null)
        {
            newNode.next = curr1;
        }
        else
        {
            newNode.next = curr2;
        }

        return dummy.next;

    }
}