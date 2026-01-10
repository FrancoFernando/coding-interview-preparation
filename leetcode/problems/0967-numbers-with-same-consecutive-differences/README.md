# 967. Numbers With Same Consecutive Differences

**Difficulty:** Medium
**Link:** [LeetCode](https://leetcode.com/problems/numbers-with-same-consecutive-differences/)

## Problem Description

Given two integers n and k, return an array of all the integers of length n where the difference between every two consecutive digits is k. You may return the answer in any order.

Note that the integers should not have leading zeros. Integers as 02 and 043 are not allowed.

Example 1:

Input: n = 3, k = 7
Output: [181,292,707,818,929]

Example 2:

Input: n = 2, k = 1
Output: [10,12,21,23,32,34,43,45,54,56,65,67,76,78,87,89,98]

Constraints:

2 <= n <= 9
0 <= k <= 9

## Approach

Since we need to build numbers digit by digit with constraints, this suggests a recursive or backtracking approach.
Each digit we add has limited options based on the previous digit:

- For each position, given the previous digit d, we can only use d+k or d-k as the next digit (if they are valid digits 0-9).
- We need to start with a non-zero digit.
- We need to track the number we're building as we go.

## Complexity

- **Time Complexity:** O(2^n) in the worst case, as each position could have at most 2 choices
- **Space Complexity:** O(n) for the recursion stack, plus O(2^n) for storing the results
