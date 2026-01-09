# 83. Remove Duplicates from Sorted List

**Difficulty:** Easy
**Link:** [LeetCode](https://leetcode.com/problems/remove-duplicates-from-sorted-list/)

## Problem Description

Given the head of a sorted linked list, delete all duplicates such that each element appears only once. Return the linked list sorted as well.

Example 1:

Input: head = [1,1,2]
Output: [1,2]

Example 2:

Input: head = [1,1,2,3,3]
Output: [1,2,3]

Constraints:

The number of nodes in the list is in the range [0, 300].
-100 <= Node.val <= 100
The list is guaranteed to be sorted in ascending order.

## Approach

Fast/slow pointer approach.
Slow is the current node, fast is the next node.
When fast is different from slow, append fast to slow.

## Complexity

- **Time Complexity:** O(n)
- **Space Complexity:** O(1)
