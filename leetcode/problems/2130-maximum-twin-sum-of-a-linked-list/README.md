# 2130. Maximum Twin Sum of a Linked List

**Difficulty:** Medium
**Link:** [LeetCode](https://leetcode.com/problems/maximum-twin-sum-of-a-linked-list/)

## Problem Description

In a linked list of size n, where n is even, the ith node (0-indexed) of the linked list is known as the twin of the (n-1-i)th node.

Return the maximum twin sum of the linked list.

## Approach

1. Find the middle using fast/slow pointers
2. Reverse the second half of the list
3. Compare nodes from start and reversed second half, tracking max sum

## Complexity

- **Time Complexity:** O(n)
- **Space Complexity:** O(1)
