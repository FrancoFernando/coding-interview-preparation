public class Solution {
    private static readonly (int x, int y)[] Directions = { (1, 0), (0, 1), (-1, 0), (0, -1) };

    public int MaxAreaOfIsland(int[][] grid) {
        if (grid == null || grid.Length == 0 || grid[0].Length == 0)
            return 0;

        int maxArea = 0;
        int m = grid.Length, n = grid[0].Length;

        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                if (grid[i][j] == 1) {
                    maxArea = Math.Max(maxArea, Dfs(grid, i, j));
                }
            }
        }
        return maxArea;
    }

    private int Dfs(int[][] grid, int i, int j) {
        if (i < 0 || j < 0 || i >= grid.Length || j >= grid[0].Length || grid[i][j] != 1) {
            return 0;
        }

        grid[i][j] = 0; // Mark as visited
        int area = 1;

        foreach (var (dx, dy) in Directions) {
            area += Dfs(grid, i + dx, j + dy);
        }
        return area;
    }
}
