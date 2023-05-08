public class Solution {

    public int DiagonalSum(int[][] mat) {
        
        int length = mat.Length, ans = 0;

        for (int i = 0; i < length; ++i) {
            ans += mat[i][i];
            ans += mat[i][length-1-i];
        }

        return ((length & 1) == 1) ? ans-mat[length/2][length/2] : ans;
    }
}
