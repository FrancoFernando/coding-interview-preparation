public class Solution {
    public int SnakesAndLadders(int[][] board) {
        int n = board.Length;
        var q = new Queue<(int position, int moves)>();
        q.Enqueue((1,0));
        var visited = new HashSet<int>();
        var flatBoard = FlattenBoard(board);

        while (q.Count > 0) {
		
            var (position, moves) = q.Dequeue();
			
			// this check is necessary because a position could
			// inserted multiple time in the queue before getting visited
			if (visited.Contains(position)) {
				continue;
            }
			
            visited.Add(position);
			
            foreach (var nextPosition in RollDice(flatBoard, position)) {
                if (nextPosition == n*n) {
                    return moves+1;
                }

                if (!visited.Contains(nextPosition)) {
                    q.Enqueue((nextPosition,moves+1));
                }
            }
        }
        return -1;
    }

     private int[] FlattenBoard(int[][] board) {
        int n = board.Length;
        var flatBoard = new int[n * n + 1];
        flatBoard[1] = -1;
        int position = 1;

        bool goingRight = true;

        for (int row = n - 1; row >= 0; row--) {
            if (goingRight) {
                for (int col = 0; col < n; col++) {
                    flatBoard[position++] = board[row][col];
                }
            } else {
                for (int col = n - 1; col >= 0; col--) {
                    flatBoard[position++] = board[row][col];
                }
            }
            goingRight = !goingRight;
        }
        return flatBoard;
    }

    private List<int> RollDice(int[] board, int position) {
        
        var reachedSquares = new List<int>();
        for (int i = 1; i <= 6 && (position+i < board.Length); i++) { 
            reachedSquares.Add(board[position+i] == -1 ? position+i : board[position+i]); 
        }
        return reachedSquares;
    }
}
