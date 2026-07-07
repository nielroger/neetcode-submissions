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
    public bool IsValidBST(TreeNode root) {
        
        return IsValidBST(root, null, null);
    }

    public bool IsValidBST(TreeNode root, TreeNode p, TreeNode q)
    {
        if(root == null) return true;
        if(p != null && root.val >= p.val) return false;
        if(q != null && root.val <= q.val) return false;

        return IsValidBST(root.left, root, q) && IsValidBST(root.right, p, root);

    }
}
