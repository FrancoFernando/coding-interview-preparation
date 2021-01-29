class Solution {
    map<int, map<int, vector<int>>> x2y2val;
    
    void fillValues(TreeNode* root, int x, int y) {
        if (!root) return;
        x2y2val[x][y].push_back(root->val);
        fillValues(root->left, x-1, y+1);
        fillValues(root->right, x+1, y+1);
    }
    
public:
    vector<vector<int>> verticalTraversal(TreeNode* root) {
        fillValues(root, 0, 0);
        vector<vector<int>> traversal;
        
        for (auto& x : x2y2val) {
            traversal.emplace_back(vector<int>());
            for (auto& y : x.second) {
                sort(y.second.begin(),y.second.end());
                traversal.back().insert(end(traversal.back()), begin(y.second), end(y.second));
            }
        }
        
        return traversal;
    }
};