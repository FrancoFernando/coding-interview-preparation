public class Solution {

    private static readonly (int dx, int dy)[] Directions = { (1, 0), (0, 1), (-1, 0), (0, -1) };

    public int NearestExit(char[][] maze, int[] entrance) {
        int rows = maze.Length;
        int cols = maze[0].Length;
        
        var q = new Queue<(int row, int col, int steps)>();
        var visited = new HashSet<(int, int)>();
        
        q.Enqueue((entrance[0], entrance[1], 0));
        visited.Add((entrance[0], entrance[1]));

        while(q.Count > 0) {
            
            var (row, col, steps) = q.Dequeue();
            
            foreach (var (dx, dy) in Directions) {
                int newRow = row + dx;
                int newCol = col + dy;

                if (!IsValidCell(newRow, newCol, rows, cols) || 
                    visited.Contains((newRow, newCol)) || 
                    maze[newRow][newCol] == '+') {
                        continue;
                    }
                    
                if (IsExit(newRow, newCol, rows, cols))
                    return steps+1;

                visited.Add((newRow,newCol));
                q.Enqueue((newRow,newCol,steps+1));
            }
        }

        return -1;
    }

    private bool IsValidCell(int row, int col, int rows, int cols) {
        return row >= 0 && row < rows && col >= 0 && col < cols;
    }

    private bool IsExit(int row, int col, int rows, int cols) {
        return row == 0 || row == rows - 1 || col == 0 || col == cols - 1;
    }
}
