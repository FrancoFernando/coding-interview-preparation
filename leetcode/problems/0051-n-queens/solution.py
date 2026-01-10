"""
LeetCode #51: N-Queens
Difficulty: Hard
Link: https://leetcode.com/problems/n-queens/
"""
from typing import List


class Solution:
    def solveNQueens(self, n: int) -> List[List[str]]:
        def is_valid(row: int, col: int) -> bool:
            for i in range(row):
                if board[i] == col or \
                   board[i] - i == col - row or \
                   board[i] + i == col + row:
                    return False
            return True

        def backtrack(row: int):
            if row == n:
                result.append(
                    ["".join('Q' if c == j else '.' for j in range(n)) for c in board]
                )
                return
            for col in range(n):
                if is_valid(row, col):
                    board[row] = col
                    backtrack(row + 1)

        board = [-1] * n
        result = []
        backtrack(0)
        return result
