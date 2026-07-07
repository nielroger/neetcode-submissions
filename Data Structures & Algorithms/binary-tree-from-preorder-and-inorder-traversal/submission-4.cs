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

    int preorderIndex = 0;
    Dictionary<int, int> inorderMap = new Dictionary<int, int>();    
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        
        for(int i = 0; i < inorder.Length; i++)
        {
            inorderMap[inorder[i]] = i;
        }

        return Build(preorder, inorder, 0, inorder.Length - 1);
    }

    public TreeNode Build(int[] preorder, int[] inorder, int left, int right)
    {
        if(left > right)
            return null;
        
        int rootVal = preorder[preorderIndex++];
        int index = inorderMap[rootVal];

        var root = new TreeNode(rootVal);
        root.left = Build(preorder, inorder, left, index - 1);
        root.right = Build(preorder, inorder, index + 1, right);   

        return root; 
    }
}
