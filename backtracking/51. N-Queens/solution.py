class Solution:
    def solveNQueens(self, n):
        def is_valid(row, col):
            for i in range(row):
                if board[i] == col or \
                board[i] - i == col - row or \
                board[i] + i == col + row:
                    return False
            return True

        def backtrack(row):
            if row == n:
                result.append(["".join('Q' if c == j else '.' for j in range(n)) for c in board])
                return
            for col in range(n):
                if is_valid(row, col):
                    board[row] = col
                    backtrack(row + 1)
        
        board = [-1] * n
        result = []
        backtrack(0)
        return result
