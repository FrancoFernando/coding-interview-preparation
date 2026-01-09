# 1721. Swapping Nodes in a Linked List

**Difficulty:** Medium
**Link:** [LeetCode](https://leetcode.com/problems/swapping-nodes-in-a-linked-list/)

## Problem Description

You are given the head of a linked list, and an integer k. Return the head of the linked list after swapping the values of the kth node from the beginning and the kth node from the end.

## Approach

1. Find the kth node from the beginning
2. Use two pointers (k nodes apart) to find the kth node from end
3. Swap the values

## Complexity

- **Time Complexity:** O(n)
- **Space Complexity:** O(1)
