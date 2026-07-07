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
    public Dictionary<int, int> inorderMap;
    public int preOrderIndex = 0;
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        inorderMap = new Dictionary<int, int>();

        for(int i = 0 ; i < inorder.Length; i++)
        {
            inorderMap.Add(inorder[i],i);
        }

        return BuildTree(preorder, inorder, 0, inorder.Length - 1);

    }

    public TreeNode BuildTree(int[] preorder, int[] inorder, int left, int right)
    {
        if(left > right)  return null;

        int rootVal = preorder[preOrderIndex++];
        int index = inorderMap[rootVal];
        var root = new TreeNode(rootVal);
        root.left = BuildTree(preorder, inorder, left, index - 1);
        root.right = BuildTree(preorder, inorder, index + 1, right);

        return root;
    }
}
