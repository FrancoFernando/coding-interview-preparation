# 93. Restore IP Addresses

**Difficulty:** Medium
**Link:** [LeetCode](https://leetcode.com/problems/restore-ip-addresses/)

## Problem Description

A valid IP address consists of exactly four integers separated by single dots. Each integer is between 0 and 255 (inclusive) and cannot have leading zeros.

Given a string s containing only digits, return all possible valid IP addresses that can be formed by inserting dots into s.

Example 1:

Input: s = "25525511135"
Output: ["255.255.11.135","255.255.111.35"]

Example 2:

Input: s = "0000"
Output: ["0.0.0.0"]

Example 3:

Input: s = "101023"
Output: ["1.0.10.23","1.0.102.3","10.1.0.23","10.10.2.3","101.0.2.3"]

Constraints:

1 <= s.length <= 20
s consists of digits only.

## Approach

Backtracking problem where at each recursion step we have to validate the current octet.

## Complexity

- **Time Complexity:** O(1) because an IP address always has 4 parts, and each part can have at most 3 digits
- **Space Complexity:** O(1) for the same reason - the maximum depth of recursion is 4
