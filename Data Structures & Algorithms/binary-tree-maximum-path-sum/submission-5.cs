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
        
        MaxSum(root);
        return maxSum;
    }

    public int MaxSum(TreeNode root)
    {
        if(root == null)  return 0;

        int left = Math.Max(MaxSum(root.left), 0);
        int right = Math.Max(MaxSum(root.right), 0);

        maxSum = Math.Max(maxSum, left + right + root.val);
        return Math.Max(left, right) + root.val;
    }
}
