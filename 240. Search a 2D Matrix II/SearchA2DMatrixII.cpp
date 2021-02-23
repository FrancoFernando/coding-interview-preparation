class Solution {
    
    bool isValid (int x, int y, int rows, int cols) {
        return y >= 0 && x < rows;
    }
    
public:
    bool searchMatrix(vector<vector<int>>& matrix, int target) {
        
        int rows = matrix.size(), cols = matrix[0].size();
        int x = 0, y = cols-1;        
        
        while (isValid(x,y,rows,cols)) {
            if (matrix[x][y] == target) return true;
            if (matrix[x][y] > target) y = y-1;
            else x = x+1;
        }
        return false;
    }
};