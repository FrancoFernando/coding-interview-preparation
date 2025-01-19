// Not space optimized
public class Solution {
    public int UniquePaths(int m, int n) {
        
        int[][] grid = new int[m][];

        for (int i = 0; i < m; ++i) {
            grid[i] = new int[n];
            grid[i][0] = 1; //init first col
        }

        for (int j = 0; j < n; j++) {
            grid[0][j] = 1; //init first row
        }

        for (int i = 1; i < m; ++i) {
            for (int j = 1; j < n; ++j) {
                grid[i][j] = grid[i-1][j] + grid[i][j-1];
            }
        }

        return grid[m-1][n-1];
    }
}

// Space optimized

public class Solution {
    public int UniquePaths(int m, int n) {
        
        int[] dp = new int[n];

        for (int j = 0; j < n; j++) {
            dp[j] = 1; 
        }

        for (int i = 1; i < m; ++i) {
            for (int j = 1; j < n; ++j) {
                dp[j] += dp[j-1];
            }
        }

        return dp[n-1];
    }
}
