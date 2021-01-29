class Solution {
    
    vector<vector<vector<int>>> dp;
    
    int ccr(vector<vector<int>>& grid, int row, int c1, int c2) {
        
        if (row >= grid.size()) return 0;
        
        if (dp[row][c1][c2] > 0) return dp[row][c1][c2];
        
        int cnt = ccr(grid, row+1, c1, c2);
        if (grid[row][c1] && grid[row][c2]) cnt++;
        
        dp[row][c1][c2] = cnt;
        return cnt;
    }
    
public:
    int countCornerRectangles(vector<vector<int>>& grid) {     
        
        dp.resize(grid.size(), vector<vector<int>>(grid[0].size(),vector<int>(grid[0].size(),0)));
        
        int cnt = 0;
        for (int i = 0; i < grid.size(); ++i) {
            for (int j = 0; j < grid[0].size(); ++j) {
                for (int k = j+1; k < grid[0].size(); ++k) {
                    if (grid[i][j] && grid[i][k]) {
                        cnt += ccr(grid, i+1, j, k);
                    }
                }
            }
        }  
        return cnt;
    }
};