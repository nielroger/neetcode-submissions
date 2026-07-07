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
        if (node == null) return null;
        
        var dict = new Dictionary<Node, Node>();
        dict.Add(node, new Node(node.val));
        var q = new Queue<Node>();
        q.Enqueue(node);
        while(q.Count > 0)
        {
            var temp = q.Dequeue();

            foreach(var item in temp.neighbors)
            {
                if(!dict.ContainsKey(item))
                {
                    dict.Add(item, new Node(item.val));
                    q.Enqueue(item);
                }
                dict[temp].neighbors.Add(dict[item]);
            }
        }

        return dict[node];
    }
}