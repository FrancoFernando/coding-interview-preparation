# 51. N-Queens

**Difficulty:** Hard
**Link:** [LeetCode](https://leetcode.com/problems/n-queens/)

## Problem Description

The n-queens puzzle is the problem of placing n queens on an n x n chessboard such that no two queens attack each other.

Given an integer n, return all distinct solutions to the n-queens puzzle. You may return the answer in any order.

Each solution contains a distinct board configuration of the n-queens' placement, where 'Q' and '.' both indicate a queen and an empty space, respectively.

Example 1:

Input: n = 4
Output: [[".Q..","...Q","Q...","..Q."],["..Q.","Q...","...Q",".Q.."]]

Example 2:

Input: n = 1
Output: [["Q"]]

Constraints:

1 <= n <= 9

## Approach

Use backtracking to place queens row by row. For each row, try placing a queen in each column and check if it's valid (no conflicts with previously placed queens in same column, diagonal, or anti-diagonal).

## Complexity

- **Time Complexity:** O(n!)
- **Space Complexity:** O(n)
