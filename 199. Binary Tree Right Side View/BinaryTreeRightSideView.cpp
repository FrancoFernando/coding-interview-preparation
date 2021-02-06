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
    
    void rightSideView(TreeNode* root, vector<int>& rsv, int height) { 
        
        if (!root) return;
        if (rsv.size() == height) rsv.push_back(root->val);
        rightSideView(root->right, rsv, height+1);
        rightSideView(root->left, rsv, height+1);
    }
    
public:
    vector<int> rightSideView(TreeNode* root) {        
        vector<int> rsv;
        rightSideView(root, rsv, 0);
        return rsv;
    }
};