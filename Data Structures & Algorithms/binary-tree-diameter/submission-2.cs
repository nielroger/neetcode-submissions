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
    public int diameter;
    public int DiameterOfBinaryTree(TreeNode root) {
        MaxLength(root);
        return diameter;
    }

    public int MaxLength(TreeNode root)
    {
        if(root == null) return 0;
        
        int left = MaxLength(root.left);
        int right = MaxLength(root.right);

        diameter = Math.Max(left + right, diameter);
        return 1 + Math.Max(left, right);

    }
}
