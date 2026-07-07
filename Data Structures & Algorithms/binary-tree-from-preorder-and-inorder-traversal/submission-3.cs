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

    Dictionary<int, int> inorderMap = new Dictionary<int,int>();
    int preOrderIndex = 0;
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        
        for(int i = 0; i < inorder.Length; i++)
        {
            inorderMap[inorder[i]] = i;
        }

        var node = Build(preorder, inorder, 0, preorder.Length - 1);
        return node;
    }

    public TreeNode Build(int[] preorder, int[] inorder, int left, int right)
    {

        if(left > right)
            return null;

        int rootVal = preorder[preOrderIndex++];
        var root = new TreeNode(rootVal);
        int index = inorderMap[rootVal];
        root.left = Build(preorder, inorder, left, index - 1);
        root.right = Build(preorder, inorder, index + 1, right);
        return root;

    }
}
