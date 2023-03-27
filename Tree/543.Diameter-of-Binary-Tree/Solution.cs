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
    
    int diameter = 0;
    
    private int dfs(TreeNode root) {
        
        if (root == null) return 0;
        
        int maxEdgesLeft = dfs(root.left);
        int maxEdgesRight = dfs(root.right);
        diameter = Math.Max(maxEdgesLeft + maxEdgesRight, diameter);
        return Math.Max(maxEdgesLeft, maxEdgesRight) + 1;
    }
    
    public int DiameterOfBinaryTree(TreeNode root) {
        dfs(root);
        return diameter;
    }
}
