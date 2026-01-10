# 39. Combination Sum

**Difficulty:** Medium
**Link:** [LeetCode](https://leetcode.com/problems/combination-sum/)

## Problem Description

Given an array of distinct integers candidates and a target integer target, return a list of all unique combinations of candidates where the chosen numbers sum to target. You may return the combinations in any order.

The same number may be chosen from candidates an unlimited number of times.

Example 1:

Input: candidates = [2,3,6,7], target = 7
Output: [[2,2,3],[7]]

Example 2:

Input: candidates = [2,3,5], target = 8
Output: [[2,2,2,2],[2,3,3],[3,5]]

Constraints:

1 <= candidates.length <= 30
2 <= candidates[i] <= 40
All elements of candidates are distinct.
1 <= target <= 40

## Approach

As long as the sum of the chosen numbers is less than target you can pick another number.
When you find a valid combination you need to backtrack to look for another combination.
Sorting the input is critical to avoid duplicate combinations and pruning the search as soon as the current sum exceeds target.

## Complexity

- **Time Complexity:** O(n * 2^n) since for each of the n candidates we can include it or not. Can be simplified to O(target).
- **Space Complexity:** O(n), simplified to O(target)
