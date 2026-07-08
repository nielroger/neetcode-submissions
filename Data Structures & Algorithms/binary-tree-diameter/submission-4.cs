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

    public int diameter = 0;
    public int DiameterOfBinaryTree(TreeNode root) {        

        MaxDepth(root);
        return diameter;
    }

    public int MaxDepth(TreeNode node)
    {
        if(node == null) return 0;
        int left = MaxDepth(node.left);
        int right = MaxDepth(node.right);
        diameter = Math.Max(diameter, left + right);
        return 1 + Math.Max(left, right);
    }
}
