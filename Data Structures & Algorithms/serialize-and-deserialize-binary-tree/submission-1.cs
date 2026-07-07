/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Codec {

    // Encodes a tree to a single string.
    public string Serialize(TreeNode root) {
        
        var res = new List<string>();
        void DFS(TreeNode node, List<string> res)
        {
            if(node == null) 
                res.Add("NA");
            else
            {
                res.Add(node.val.ToString());
                DFS(node.left, res);
                DFS(node.right, res);
            }
        }
        DFS(root, res);
        return string.Join(",", res);
    }

    // Decodes your encoded data to tree.
    public TreeNode Deserialize(string data) {
        var list = data.Split(',').ToList<string>();
        int i =0;
        TreeNode DFS(List<string> list)
        {
            if(list[i] == "NA")
            {
                i++;
                return null;
            }
            else
            {
                var node = new TreeNode(int.Parse(list[i++]));
                node.left = DFS(list);
                node.right = DFS(list);
                return node;
            }
        }

        var res = DFS(list);
        return res;
    }
}
