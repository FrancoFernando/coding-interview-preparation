public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        
        IList<IList<int>> triangle = new List<IList<int>>(){new int[1]{1}};

        for (int row = 1; row < numRows; ++row) {

            triangle.Add(new int[row+1]);

            for (int j = 0; j <= row; ++j) {
                int aboveLeft = (j == 0) ? 0 : triangle[row-1][j-1];
                int aboveRight = (j == row) ? 0 : triangle[row-1][j];
                triangle[row][j] = aboveLeft + aboveRight;
            }
        } 
        return triangle;
    }
}

/// alternative approach

public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        
        IList<IList<int>> triangle = new List<IList<int>>(){new int[1]{1}};      
        
        for (int row = 0; row < numRows-1; ++row)
        {
            triangle.Add(new int[row+2]);
            for (int j = 0; j <= row; ++j) {
                triangle[row+1][j] += triangle[row][j];
                triangle[row+1][j+1] += triangle[row][j];
            }
        } 
        
        return triangle;
    }
}
