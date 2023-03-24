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
    
    private bool IsLeaf (TreeNode node) => node.left == null && node.right == null;
    
    public int MinDepth(TreeNode root) {
        
        if (root == null) return 0;
        if (IsLeaf(root)) return 1;
        
        int minDepth = Int32.MaxValue;
        
        if (root.left != null) minDepth = Math.Min(MinDepth(root.left), minDepth);
        if (root.right != null) minDepth = Math.Min(MinDepth(root.right), minDepth);
        
        return 1+minDepth;
    }
}
