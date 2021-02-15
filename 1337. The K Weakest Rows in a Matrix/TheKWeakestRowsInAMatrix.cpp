class Solution {
public:
    vector<int> kWeakestRows(vector<vector<int>>& mat, int k) {
        
        int rows = mat.size(), cols = mat[0].size();
        vector<vector<int>> bins(cols+1,vector<int>());
        
        for (int i = 0; i < rows; ++i) {
            auto lastSoldier = lower_bound(mat[i].rbegin(), mat[i].rend(), 1);
            int soldiers = cols-distance(mat[i].rbegin(), lastSoldier);
            bins[soldiers].push_back(i);
        }
        
        vector<int> ans(k);
        
        for (int i = 0, z = 0; i <= cols && z < k; ++i) {
            for (int j = 0; j < bins[i].size() && z < k; ++j) {
                ans[z++] = bins[i][j];
            }
        }
        return ans;
    }
};