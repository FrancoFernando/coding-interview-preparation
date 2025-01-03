public class Solution {

    static readonly (int dx, int dy)[] directions={(1,0), (0,1),(-1,0),(0,-1)};

    public int OrangesRotting(int[][] grid) {
        int rows = grid.Length;
        int cols = grid[0].Length;
        int fresh = 0, rotten = 0;
        var rottenQueue = new Queue<(int row, int col, int time)>();

        for (int i = 0; i < rows; ++i) {
            for (int j = 0; j < cols; ++j) {
                if (grid[i][j] == 1)
                    fresh++;
                else if (grid[i][j] == 2)
                    rottenQueue.Enqueue((i,j, 0));
            }
        }

        if (fresh == 0) 
            return 0;

        while (rottenQueue.Count > 0) {
            
            var (row, col, time) = rottenQueue.Dequeue();

            foreach (var (dx,dy) in directions) {
                int nextRow = row+dx, nextCol = col+dy;
                if (IsInsideGrid(nextRow, nextCol, rows, cols) &&
                    grid[nextRow][nextCol] == 1) {
                        grid[nextRow][nextCol] = 2;
                        rottenQueue.Enqueue((nextRow,nextCol,time+1));
                        fresh--;

                        if (fresh == 0) 
                           return time+1;
                    }
            }
        }
        return -1;
    }

    private bool IsInsideGrid(int x, int y, int sizeX, int sizeY){
        return x >= 0 && x < sizeX && y >= 0 && y < sizeY;
    }
}
