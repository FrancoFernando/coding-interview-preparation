# 2095. Delete the Middle Node of a Linked List

**Difficulty:** Medium
**Link:** [LeetCode](https://leetcode.com/problems/delete-the-middle-node-of-a-linked-list/)

## Problem Description

You are given the head of a linked list. Delete the middle node, and return the head of the modified linked list.

The middle node of a linked list of size n is the ⌊n / 2⌋th node from the start using 0-based indexing.

Example 1:

Input: head = [1,3,4,7,1,2,6]
Output: [1,3,4,1,2,6]

Example 2:

Input: head = [1,2,3,4]
Output: [1,2,4]

Constraints:

The number of nodes in the list is in the range [1, 105].
1 <= Node.val <= 105

## Approach

**Two pass:**
- Count number of nodes
- Make a second pass to delete middle node
- Use dummy node to handle edge case

**One pass:**
- Fast and slow pointers
- When 'fast' reaches the end, 'slow' is at the middle
- Maintain a prev pointer to the node before slow

## Complexity

- **Time Complexity:** O(n)
- **Space Complexity:** O(1)
