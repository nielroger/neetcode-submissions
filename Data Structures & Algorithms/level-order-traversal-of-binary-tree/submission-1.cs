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
    public List<List<int>> LevelOrder(TreeNode root) {
        
        
        var result = new List<List<int>>();
        if(root == null) return result;
        var q = new Queue<TreeNode>();
        q.Enqueue(root);
        
        while(q.Count > 0)
        {
            int size = q.Count;
            var list = new List<int>();
            for(int i = 0; i <  size; i++)
            {
                var temp = q.Dequeue();
                list.Add(temp.val);
                if(temp.left != null) q.Enqueue(temp.left);
                if(temp.right != null) q.Enqueue(temp.right);
            }

            result.Add(list);
        }

        return result;
    }
}
