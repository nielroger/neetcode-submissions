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
    int maxSum = int.MinValue;
    public int MaxPathSum(TreeNode root) {

        MaxPath(root);
        return maxSum;
    }

    public int MaxPath(TreeNode root)
    {
        if(root == null) return 0;

        int left = Math.Max(MaxPath(root.left), 0);
        int right = Math.Max(MaxPath(root.right), 0);

        int current = root.val + left + right;
        maxSum = Math.Max(maxSum, current);

        return root.val + Math.Max(left, right);
    }
}