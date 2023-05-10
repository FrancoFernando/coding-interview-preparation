public class Solution {
    public int[][] GenerateMatrix(int n) {
        
        int[][] ans = new int[n][];
        for (int i = 0; i < n; i++) ans[i] = new int[n];

        int maxVal = n*n, val = 0;
        int upRow = 0, leftCol = 0, lowRow = n-1, rightCol = n-1;
        while (val < maxVal) {
            for (int i = leftCol; i <= rightCol; ++i) ans[upRow][i] = ++val;
            for (int i = upRow+1; i < lowRow; ++i) ans[i][rightCol] = ++val;
            for (int i = rightCol; i > leftCol; --i) ans[lowRow][i] = ++val;
            for (int i = lowRow; i > upRow; --i) ans[i][leftCol] = ++val;
            upRow++;
            leftCol++; 
            lowRow--; 
            rightCol--;
        }
        return ans;
    }
}
