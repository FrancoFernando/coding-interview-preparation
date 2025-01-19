# Description 

There is a robot on an m x n grid. The robot is initially located at the top-left corner (i.e., grid[0][0]). The robot tries to move to the bottom-right corner (i.e., grid[m - 1][n - 1]). The robot can only move either down or right at any point in time.

Given the two integers m and n, return the number of possible unique paths that the robot can take to reach the bottom-right corner.

The test cases are generated so that the answer will be less than or equal to 2 * 109.

 

Example 1:


Input: m = 3, n = 7
Output: 28
Example 2:

Input: m = 3, n = 2
Output: 3
Explanation: From the top-left corner, there are a total of 3 ways to reach the bottom-right corner:
1. Right -> Down -> Down
2. Down -> Down -> Right
3. Down -> Right -> Down
 

Constraints:

1 <= m, n <= 100

# Thought process

Let's say P[i][j] are the number of unique paths to reach cell[i][j]. 
Then from the problem definition: P[i][j] = P[i-1][j] + P[i][j-1] = paths from up + path from right

The dp approach implementing according to the formula takes O(m*n) space.

Observing that at each step we only use the previous row the space can be optimized to O(n).

When we move to a new row (in the outer loop), the values in dp already represent the number of paths from the top for each column.

# Complexity

Time complexity is O(m*n)
Space complexity is O(m*n) if not optimized or O(n) if optimized
