public class Solution {

	public IList<int> SpiralOrder(int[][] matrix) {
		return SpiralOrder(matrix, 0, matrix.Length-1, 0, matrix[0].Length-1);
	}

  public IList<int> SpiralOrder(int[][] matrix, int upperRow, int lowerRow, int leftMostCol, int rightMostCol) {
        
      if (upperRow > lowerRow || leftMostCol > rightMostCol) return new List<int>();
      var ans = new List<int>(); 
      for (int i = leftMostCol; i <= rightMostCol; ++i) ans.Add(matrix[upperRow][i]);
      for (int i = upperRow+1; i <= lowerRow; ++i) ans.Add(matrix[i][rightMostCol]);
      for (int i = rightMostCol-1; i >= leftMostCol && upperRow < lowerRow; --i) ans.Add(matrix[lowerRow][i]);
      for (int i = lowerRow-1; i > upperRow && leftMostCol < rightMostCol; --i) ans.Add(matrix[i][leftMostCol]);
      ans.AddRange(SpiralOrder(matrix, upperRow+1, lowerRow-1, leftMostCol+1, rightMostCol-1));
      return ans;
    }
}
