# 22. Generate Parentheses

**Difficulty:** Medium
**Link:** [LeetCode](https://leetcode.com/problems/generate-parentheses/)

## Problem Description

Given n pairs of parentheses, write a function to generate all combinations of well-formed parentheses.

Example 1:

Input: n = 3
Output: ["((()))","(()())","(())()","()(())","()()()"]

Example 2:

Input: n = 1
Output: ["()"]

Constraints:

1 <= n <= 8

## Approach

Once you put an open parenthesis you have two options: put another open parenthesis (if the maximum of n has not been reached) or put a closed parenthesis.

## Complexity

- **Time Complexity:** O(2^(2n)) - For each position in the string (of length 2n), we have at most 2 choices
- **Space Complexity:** O(n) for the maximum depth of recursion and storing the current combination being built
