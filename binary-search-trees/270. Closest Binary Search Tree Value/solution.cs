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
    public int ClosestValue(TreeNode root, double target) {
        
        int closest = root.val;

        while (root != null) {
            double diffToCurrent = Math.Abs(root.val-target);
            double diffToClosest = Math.Abs(closest-target);
            if ((diffToCurrent < diffToClosest) || (diffToCurrent == diffToClosest && root.val < closest)){
                closest = root.val;
            }
            
            root = target < root.val ? root.left : root.right;
        }
        return closest;
    }
}
