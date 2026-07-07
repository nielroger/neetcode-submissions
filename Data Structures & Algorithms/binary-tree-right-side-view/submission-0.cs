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
        
        var res = new List<int>();
        if(root == null) return res;
        var queue = new Queue<TreeNode>();

        queue.Enqueue(root);
        queue.Enqueue(null);
        while(queue.Count > 0)
        {            
            var temp = queue.Dequeue();
            if(temp != null && queue.Peek() == null)
            {
                res.Add(temp.val);
            }
            if(temp == null)
            {
                if(queue.Count > 0) queue.Enqueue(null);
            }
            else
            {
                if(temp.left != null) queue.Enqueue(temp.left);
                if(temp.right != null) queue.Enqueue(temp.right);
            }
            
        }
        return res;
    }


}
