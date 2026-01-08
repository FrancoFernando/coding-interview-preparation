# 1832. Check if the Sentence Is Pangram

**Difficulty:** Easy
**Link:** [LeetCode](https://leetcode.com/problems/check-if-the-sentence-is-pangram/)

## Problem Description

A pangram is a sentence where every letter of the English alphabet appears at least once.

Given a string sentence containing only lowercase English letters, return true if sentence is a pangram, or false otherwise.

Example 1:

Input: sentence = "thequickbrownfoxjumpsoverthelazydog"
Output: true
Explanation: sentence contains at least one of every letter of the English alphabet.

Example 2:

Input: sentence = "leetcode"
Output: false

## Approach

Build a hash-set with the string characters and check if its size is 26.

## Complexity

- **Time Complexity:** O(N) to build the set
- **Space Complexity:** O(1) - at most 26 characters
