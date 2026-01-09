# 1290. Convert Binary Number in a Linked List to Integer

**Difficulty:** Easy
**Link:** [LeetCode](https://leetcode.com/problems/convert-binary-number-in-a-linked-list-to-integer/)

## Problem Description

Given head which is a reference node to a singly-linked list. The value of each node in the linked list is either 0 or 1. The linked list holds the binary representation of a number.

Return the decimal value of the number in the linked list.

## Approach

Traverse the list, shifting the result left by 1 bit and OR-ing with the current node's value.

## Complexity

- **Time Complexity:** O(n)
- **Space Complexity:** O(1)
