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
    
    public int dfs(TreeNode root, int minVal, int maxVal) {
        
        int maxDiff = 0;
        
        if (root == null) return maxDiff;
        
        maxDiff = Math.Max(maxDiff, Math.Abs(root.val - minVal));
        maxDiff = Math.Max(maxDiff, Math.Abs(root.val - maxVal));
        minVal = Math.Min(minVal, root.val);
        maxVal = Math.Max(maxVal, root.val);
        
        int maxDiffLeft  = dfs(root.left, minVal, maxVal);
        int maxDiffRight = dfs(root.right, minVal, maxVal);
        
        return Math.Max(maxDiff, Math.Max(maxDiffLeft, maxDiffRight));
    }
    
    public int MaxAncestorDiff(TreeNode root) {
        return dfs(root, root.val, root.val);
    }
}
