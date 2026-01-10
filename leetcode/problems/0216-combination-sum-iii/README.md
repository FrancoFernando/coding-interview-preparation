# 216. Combination Sum III

**Difficulty:** Medium
**Link:** [LeetCode](https://leetcode.com/problems/combination-sum-iii/)

## Problem Description

Find all valid combinations of k numbers that sum up to n such that the following conditions are true:

- Only numbers 1 through 9 are used.
- Each number is used at most once.

Return a list of all possible valid combinations.

Example 1:

Input: k = 3, n = 7
Output: [[1,2,4]]

Example 2:

Input: k = 3, n = 9
Output: [[1,2,6],[1,3,5],[2,3,4]]

Example 3:

Input: k = 4, n = 1
Output: []

Constraints:

2 <= k <= 9
1 <= n <= 60

## Approach

Backtracking with constraints: pick k numbers from 1-9 that sum to n. Each number can only be used once.

## Complexity

- **Time Complexity:** O(C(9,k)) - combinations of 9 choose k
- **Space Complexity:** O(k) for recursion stack
