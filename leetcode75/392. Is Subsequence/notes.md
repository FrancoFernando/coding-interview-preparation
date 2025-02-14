# Description 

Given two strings s and t, return true if s is a subsequence of t, or false otherwise.

A subsequence of a string is a new string that is formed from the original string by deleting some (can be none) of the characters without disturbing the relative positions of the remaining characters. (i.e., "ace" is a subsequence of "abcde" while "aec" is not).

 

Example 1:

Input: s = "abc", t = "ahbgdc"
Output: true
Example 2:

Input: s = "axc", t = "ahbgdc"
Output: false
 

Constraints:

0 <= s.length <= 100
0 <= t.length <= 104
s and t consist only of lowercase English letters.
 

Follow up: Suppose there are lots of incoming s, say s1, s2, ..., sk where k >= 109, and you want to check one by one to see if t has its subsequence. In this scenario, how would you change your code?

# Thought Process

This idea is to check if s is a subsequence of t by iterating through both strings once, advancing the pointer for s only when a matching character is found in t. The final check of sIndex against s.Length determines if all characters in s were found in order in t.

# Complexity

O(n) time complexity, where n is the length of string t. The space complexity is O(1) as we're only using a constant amount of extra space.
