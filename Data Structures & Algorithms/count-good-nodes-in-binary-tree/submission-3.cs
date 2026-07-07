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
    public int GoodNodes(TreeNode root) {
        return GoodNodes(root.val, root);
    }

    public int GoodNodes(int largest, TreeNode root)
    {
        if(root == null) return 0;

        if(root.val >= largest)
        {
            largest = root.val;
            return 1 + GoodNodes(largest, root.left) + GoodNodes(largest, root.right);
        }
        else
        {
            return GoodNodes(largest, root.left) + GoodNodes(largest, root.right);
        }
    }
}