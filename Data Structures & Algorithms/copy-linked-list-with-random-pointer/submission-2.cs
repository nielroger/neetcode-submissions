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
        
        var curr = head;

        while(curr != null)
        {
            var node = new Node(curr.val);
            node.next = curr.next;
            curr.next = node;
            curr = node.next;            
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
        
        var newNode = dummy;

        curr = head;

        while(curr != null)
        {
            newNode.next = curr.next;
            curr.next = curr.next.next;
            curr = curr.next;
            newNode = newNode.next;
        }

        return dummy.next;
    }
}
