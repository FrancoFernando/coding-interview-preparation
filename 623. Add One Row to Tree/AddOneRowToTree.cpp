/**
 * Definition for a binary tree node.
 * struct TreeNode {
 *     int val;
 *     TreeNode *left;
 *     TreeNode *right;
 *     TreeNode() : val(0), left(nullptr), right(nullptr) {}
 *     TreeNode(int x) : val(x), left(nullptr), right(nullptr) {}
 *     TreeNode(int x, TreeNode *left, TreeNode *right) : val(x), left(left), right(right) {}
 * };
 */
class Solution {
    
    TreeNode* helper(TreeNode* root, int v, int d) {
        
        if (!root) return nullptr;
        
        root->left = (d == 1) ? new TreeNode(v, root->left, nullptr) : helper(root->left, v, d-1);
        root->right = (d == 1) ? new TreeNode(v, nullptr, root->right) : helper(root->right, v, d-1);
        return root;
    }
    
public:
    TreeNode* addOneRow(TreeNode* root, int v, int d) {
        
        if (d == 1) return new TreeNode(v, root, nullptr);
        return helper(root, v, d-1);
    }
};
