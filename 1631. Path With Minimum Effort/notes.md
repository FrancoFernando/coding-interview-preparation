# Thinking Process

1. first idea is to use DP, but I didn't realize that moving in 4 directions will cause dependency loops -> so you can't use backtracking + dp; when you compute the mep from a cell you assume you already visited some other cell that maybe lead to the optimal path
The following without dp works but has exponential complexity
```cpp
class Solution {
   
    vector<vector<int>> dp;
   
    int mep(vector<vector<int>>& heights, int i, int j) {
       
        if (i == heights.size()-1 && j == heights[0].size()-1) return 0;
       
        if (i == 1 && j == 2) {
            i = 1;
        }
       
        if (dp[i][j] >= 0) return dp[i][j];
       
        int ans = INT_MAX, h = heights[i][j];
        heights[i][j] = 0;
       
        if (i > 0 && heights[i-1][j] > 0) {
            ans = min(ans, max(abs(h-heights[i-1][j]), mep(heights, i-1, j)));
        }
        if (i < (heights.size()-1) && heights[i+1][j] > 0) {
            ans = min(ans, max(abs(h-heights[i+1][j]), mep(heights, i+1, j)));
        }
        if (j < (heights[0].size()-1) && heights[i][j+1] > 0) {
            ans = min(ans, max(abs(h-heights[i][j+1]), mep(heights, i, j+1)));
        }
        if (j > 0 && heights[i][j-1] > 0) {
            ans = min(ans, max(abs(h-heights[i][j-1]), mep(heights, i, j-1)));
        }
       
        heights[i][j] = h;
        dp[i][j] = ans;
        return ans;
    }
   
public:
    int minimumEffortPath(vector<vector<int>>& heights) {
        dp.resize(heights.size(), vector<int>(heights[0].size(), -1));
        return mep(heights, 0, 0);
    }
};
```

# Complexity

* N = rows, M = cols
* O(NMlog(min(N,M))) time, since each element is accessed a costant number of times and the sort of a diagonal 
  costs min(N,M)log(min(N,M)). The max size of a diagonal is min(N,M).
* O(min(N,M)) space for the temporary structure


