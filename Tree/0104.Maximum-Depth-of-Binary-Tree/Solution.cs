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
    public int MaxDepth(TreeNode root) {
        
        if (root == null) return 0;

        return 1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right));
    }
}

//Iterative
public class Solution {
    public int MaxDepth(TreeNode root) {
        
        int maxDepth = 0;

        var s = new Stack<(TreeNode, int)>();
        if (root != null) s.Push((root,1));

        while (s.Count() > 0) {
            var (node, depth) = s.Pop();
            maxDepth = Math.Max(maxDepth, depth);
            if (node.left != null) s.Push((node.left, depth+1));
            if (node.right != null) s.Push((node.right, depth+1));
        }
 
        return maxDepth;
    }
}
