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
        
        //create a clone next to it

        var curr = head;        
        while(curr != null)
        {
            var copy = new Node(curr.val);
            copy.next = curr.next;
            curr.next = copy;
            curr = curr.next.next;
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
        var newNode =  dummy;        
        curr = head;
        while(curr != null)
        {
            newNode.next = curr.next;
            curr.next = curr.next.next;
            newNode = newNode.next;                        
            curr = curr.next;
        }
        
        return dummy.next;        

    }
}
