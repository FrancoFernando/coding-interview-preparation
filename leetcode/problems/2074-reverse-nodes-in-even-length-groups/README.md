# 2074. Reverse Nodes in Even Length Groups

**Difficulty:** Medium
**Link:** [LeetCode](https://leetcode.com/problems/reverse-nodes-in-even-length-groups/)

## Problem Description

You are given the head of a linked list. The nodes in the linked list are sequentially assigned to non-empty groups whose lengths form the sequence 1, 2, 3, 4, ...

Reverse the nodes in each group with an even length, and return the head of the modified linked list.

## Approach

1. Calculate total length of the list
2. For each group, determine actual length (min of remaining nodes and group number)
3. If even length, reverse the group; otherwise skip it

## Complexity

- **Time Complexity:** O(n)
- **Space Complexity:** O(1)
