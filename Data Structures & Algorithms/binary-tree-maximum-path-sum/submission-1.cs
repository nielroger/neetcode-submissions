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
        GetMaxGain(root);
        return maxSum;
    }

    public int GetMaxGain(TreeNode root)
    {
        if(root == null) return 0;

        int left = Math.Max(0,GetMaxGain(root.left));
        int right = Math.Max(0,GetMaxGain(root.right));

        int currentSum = root.val + left + right;

        maxSum = Math.Max(currentSum, maxSum);

        return root.val + Math.Max(left, right);
    }
}
