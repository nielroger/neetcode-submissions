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
    int count;
    int result;
    public int KthSmallest(TreeNode root, int k) {
        
        InOrder(root, k);
        return result;
    }

    public void InOrder(TreeNode root, int k)
    {
        if(root == null) return;

        if(root.left != null) InOrder(root.left, k);

        count++;
        if(count == k)
        {
            result = root.val;
            return;
        }

        InOrder(root.right,k);
    }
}
