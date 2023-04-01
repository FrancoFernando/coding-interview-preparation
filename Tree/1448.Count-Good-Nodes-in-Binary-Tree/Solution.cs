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

    private int dfs (TreeNode node, int maxValFromRootToNode) {
        
        if (node is null) return 0;

        int goodNodesInSubtree = 0;

        if (node.val >= maxValFromRootToNode) {
            goodNodesInSubtree++;
            maxValFromRootToNode = node.val;
        }

        goodNodesInSubtree += dfs(node.left, maxValFromRootToNode);
        goodNodesInSubtree += dfs(node.right, maxValFromRootToNode);

        return goodNodesInSubtree;
    }

    public int GoodNodes(TreeNode root) {
        return dfs(root, root.val);
    }
}
