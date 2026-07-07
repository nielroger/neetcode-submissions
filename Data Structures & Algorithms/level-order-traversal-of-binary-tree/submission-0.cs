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
 
public class Solution {
    public List<List<int>> LevelOrder(TreeNode root) {
        
        var res = new List<List<int>>();

        if(root == null) return res;

        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while(queue.Count > 0)
        {
            var count = queue.Count;
            var list = new List<int>();
            for(int i = 0; i < count; i++)
            {
                var temp = queue.Dequeue();
                list.Add(temp.val);
                if(temp.left != null) queue.Enqueue(temp.left);
                if(temp.right != null) queue.Enqueue(temp.right);
            }
            res.Add(list);
        }

        return res;
    }
}
