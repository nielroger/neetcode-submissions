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
    private int diameter;
    public int DiameterOfBinaryTree(TreeNode root) {
        MaxDepth(root);
        return diameter;    
    }

    public int MaxDepth(TreeNode root)
    {
        if(root == null) return 0;

        int left = MaxDepth(root.left);
        int right = MaxDepth(root.right);

        diameter = Math.Max(diameter, left + right);
        return 1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right));
    }


}
