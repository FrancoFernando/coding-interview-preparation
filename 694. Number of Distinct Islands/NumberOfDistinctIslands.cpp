class Solution {
    
    int rows;
    int cols;
    
    string numDistinctIslands(vector<vector<int>>& grid, int i, int j) {
        
        if (i < 0 || j < 0 || i >= grid.size() || j >= grid[0].size() ||
           grid[i][j] <= 0) return "";
        
        grid[i][j] = -1;
        string s;
        
        if (i-1 >= 0 && grid[i-1][j] > 0) {
            s += "U" + numDistinctIslands(grid, i-1, j) + "D";
        }
        
        if (j+1 < cols && grid[i][j+1] > 0) {
            s += "R" + numDistinctIslands(grid, i, j+1) + "L";
        }
        
        if (i+1 < rows && grid[i+1][j] > 0) {
            s += "D" + numDistinctIslands(grid, i+1, j) + "U";
        }
        
        if (j-1 >= 0 && grid[i][j-1] > 0) {
            s += "L" + numDistinctIslands(grid, i, j-1) + "R";
        }
        
        return s;
    }
    
public:
    int numDistinctIslands(vector<vector<int>>& grid) {
        
        rows = grid.size();
        cols = grid[0].size();
        unordered_set<string> islands;
        for (int i = 0; i < rows; ++i) {
            for (int j = 0; j < cols; ++j) {
                if (grid[i][j] > 0) {
                    islands.emplace("S"+numDistinctIslands(grid, i, j));
                }
            }
        }
        return islands.size();
    }
};