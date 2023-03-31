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
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root) {
        
        var traversal = new List<IList<int>>();
        
        var q = new Queue<TreeNode>();
        if (root != null) q.Enqueue(root);
        
        bool rightToLeft = true;
        
        while (q.Count() > 0) {
            
            rightToLeft = !rightToLeft;
            int numberOfNodes = q.Count();
            var levelTraversal = new List<int>(numberOfNodes);
            
            for (int i = 0; i < numberOfNodes; ++i) {
                var node = q.Dequeue();
                if (node.left != null) q.Enqueue(node.left);
                if (node.right != null) q.Enqueue(node.right);
                levelTraversal.Add(node.val);
            }
            if (rightToLeft) levelTraversal.Reverse();
            traversal.Add(levelTraversal);
        }
        return traversal;
    }
}
