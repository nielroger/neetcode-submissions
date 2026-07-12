/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
    public Node CloneGraph(Node node) {
        
        if(node == null) return null;
        var q = new Queue<Node>();
        var dict = new Dictionary<Node, Node>();

        q.Enqueue(node);
        dict.Add(node, new Node(node.val));
        while(q.Count > 0)
        {
            var temp = q.Dequeue();
            
            foreach(var neighbor in temp.neighbors)
            {
                if(!dict.ContainsKey(neighbor))
                {
                    dict.Add(neighbor, new Node(neighbor.val));
                    q.Enqueue(neighbor);
                }
                dict[temp].neighbors.Add(dict[neighbor]);
            }
        }

        return dict[node];
    }
}
