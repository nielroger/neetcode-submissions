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

    int preIndex = 0;
    Dictionary<int, int> inorderMap = new Dictionary<int, int>();    
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        
        for(int i =0; i < inorder.Length; i++)
        {
            inorderMap.Add(inorder[i], i);
        }
        var node = BuildTree(preorder, inorder, 0, preorder.Length -1);
        return node;
    }

    public TreeNode BuildTree(int[] preorder, int[] inorder, int left, int right)
    {
        if(left > right)
        {
            return null;
        }

        var root = new TreeNode(preorder[preIndex++]);
        int index = inorderMap[root.val];
        root.left = BuildTree(preorder, inorder, left, index - 1);
        root.right = BuildTree(preorder, inorder, index + 1, right);

        return root;
    }
}
