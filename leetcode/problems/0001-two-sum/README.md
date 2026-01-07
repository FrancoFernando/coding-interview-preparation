# 1. Two Sum

**Difficulty:** Easy  
**Link:** [LeetCode](https://leetcode.com/problems/two-sum/)

## Problem Description

Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

You can return the answer in any order.

## Approach

If x+y = target, then target-y = x. For each y in the input, check if there is an already seen x. To make the check fast store already seen numbers in a dictionary.

## Complexity

- **Time Complexity:** O(N) time to iterate over the input and execute O(1) operations
- **Space Complexity:** O(N) space for the hash-table

## Notes

Alternative approach: sorting + two pointers
