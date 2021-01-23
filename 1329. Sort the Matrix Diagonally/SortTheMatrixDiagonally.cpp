class Solution {
    
    void diagonalSort(vector<vector<int>>& mat, int r, int c) {
        
        const int rows = mat.size(), cols = mat[0].size();
        vector<int> diag;
        for (int i = r, j = c; i < rows && j < cols; ++i, ++j) {
            diag.push_back(mat[i][j]);
        }
        sort(diag.begin(), diag.end());
        for (int i = r, j = c, k = 0; i < rows && j < cols; ++i, ++j, ++k) {
            mat[i][j] = diag[k];
        }
    }
    
public:
    vector<vector<int>> diagonalSort(vector<vector<int>>& mat) {
        
        const int rows = mat.size(), cols = mat[0].size();
        for (int i = 0; i < rows; ++i) diagonalSort(mat, i, 0);
        for (int i = 1; i < cols; ++i) diagonalSort(mat, 0, i);
        return mat;
    }
};
