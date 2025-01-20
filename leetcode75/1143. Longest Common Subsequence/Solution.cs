// Top-down
public class Solution {

    private int[,] _cache;
    private string _text1, _text2;

    public int LongestCommonSubsequence(string text1, string text2) {
        _text1 = text1;
        _text2 = text2;
        _cache = new int[text1.Length, text2.Length];
        for (int i = 0; i < _cache.GetLength(0); i++)
            for (int j = 0; j < _cache.GetLength(1); j++)
                _cache[i, j] = -1;
        return LCS(0, 0);
    }

    private int LCS(int i, int j) {

        if (i == _text1.Length || j == _text2.Length) {
            return 0;
        }

        if (_cache[i, j] != -1)
            return _cache[i, j];

        int result;
        if (_text1[i] == _text2[j]) {
            result = 1 + LCS(i+1, j+1);
        }
        else {
           result = Math.Max(LCS(i+1, j), LCS(i, j+1)); 
        }

        _cache[i, j] = result;
        return result;
    }
}

//bottom-up
public class Solution {

    public int LongestCommonSubsequence(string text1, string text2) {
        int m = text1.Length;
        int n = text2.Length;
        int[,] dp = new int[m + 1, n + 1];

        for (int i = 1; i <= m; ++i) {
            for (int j = 1; j <= n; ++j) {
                if (text1[i-1] == text2[j-1])  
                    dp[i,j] = 1 + dp[i-1,j-1];
                else
                    dp[i,j] = Math.Max(dp[i-1,j], dp[i,j-1]);
            }
        }
        return dp[m,n];
    }
}
