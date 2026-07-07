/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node copyRandomList(Node head) {
        if (head == null) return null;
        var curr = head;
        while(curr != null)
        {
            var newNode = new Node(curr.val);
            newNode.next = curr.next;
            curr.next = newNode;
            curr = newNode.next;
        }

        curr = head;

        while(curr != null)
        {
            if(curr.random != null)
            {
                curr.next.random = curr.random.next;
            }
            curr = curr.next.next;
        }

        var dummy = new Node(0);
        var copyCurr = dummy;
        curr = head;
        while(curr != null)
        {
            copyCurr.next = curr.next;
            curr.next = curr.next.next;
            
            curr = curr.next;
            copyCurr = copyCurr.next;
        }

        return dummy.next;
    }
}