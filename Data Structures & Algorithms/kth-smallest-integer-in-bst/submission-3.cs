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
    int count = 0;
    int result = -1;
    public int KthSmallest(TreeNode root, int k) {
        Helper(root, k);
        return result;
    }

    public void Helper(TreeNode root, int k)
    {
        if(root == null || result != -1) return;

        Helper(root.left, k);
        
        count++;
        if(count == k) {
            result = root.val;
            return;
        }
        
        Helper(root.right, k);
    }
}