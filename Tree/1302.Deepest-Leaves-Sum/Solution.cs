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
    public int DeepestLeavesSum(TreeNode root) {
        
        int sum = 0;
        var q = new Queue<TreeNode>(new TreeNode[]{root});
        
        while (q.Count() > 0) {
            sum = 0;
            int numberOfNodes = q.Count();
            for (int i = 0; i < numberOfNodes; ++i) {
                var node = q.Dequeue();
                sum += node.val;
                q.Enqueue(node.left);
                q.Enqueue(node.right);
            }
            q = q.Where(node => node != null).;
        }
        return sum;
    }
}
