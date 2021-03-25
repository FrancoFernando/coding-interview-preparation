class Solution {
   
    int nRows = 0, nCols = 0;
    vector<vector<bool>> touchP;
    vector<vector<bool>> touchA;
   
    void dfs(vector<vector<int>>& matrix, int r, int c, vector<vector<bool>>& touch) {
        
        touch[r][c] = true;
        int val = matrix[r][c]; 
        
        if (r > 0 && matrix[r-1][c] >= val && !touch[r-1][c]) dfs(matrix, r-1, c, touch);
        if (r < nRows-1 && matrix[r+1][c] >= val && !touch[r+1][c]) dfs(matrix, r+1, c, touch);
        if (c > 0 && matrix[r][c-1] >= val && !touch[r][c-1]) dfs(matrix, r, c-1, touch);
        if (c < nCols-1 && matrix[r][c+1] >= val && !touch[r][c+1]) dfs(matrix, r, c+1, touch); 
    }
   
public:
    vector<vector<int>> pacificAtlantic(vector<vector<int>>& matrix) {
       
        if (matrix.empty()) return vector<vector<int>>();
        
        nRows = matrix.size(), nCols = matrix[0].size();
        touchP.resize(nRows, vector<bool>(nCols,0));
        touchA.resize(nRows, vector<bool>(nCols,0));
       
        for (int i = 0; i < nRows; ++i) {
            dfs(matrix, i, 0, touchP);
            dfs(matrix, i, nCols-1, touchA);  
        }
        
        for (int i = 0; i < nCols; ++i) {
            dfs(matrix, 0, i, touchP); 
            dfs(matrix, nRows-1, i, touchA);
        }
       
        vector<vector<int>> ans;
        for (int i = 0; i < nRows; ++i) {
            for (int j = 0; j < nCols; ++j) {
                if(touchP[i][j] && touchA[i][j]) ans.push_back({i,j});
            }
        }
        return ans;
    }
};