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
    public List<int> RightSideView(TreeNode root) {
        var result = new List<int>();
        if(root == null) return result;

        var q = new Queue<TreeNode>();
        q.Enqueue(root);
        q.Enqueue(null);
        while(q.Count > 0)
        {
            var temp = q.Dequeue();
            if(temp == null)
            {
                if(q.Count > 0) q.Enqueue(null);
            }
            else
            {
                if(q.Peek() == null) result.Add(temp.val);
                if(temp.left != null) q.Enqueue(temp.left);
                if(temp.right != null) q.Enqueue(temp.right);
            }                                    
        }
        return result;
    }
}