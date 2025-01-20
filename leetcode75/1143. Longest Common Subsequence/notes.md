# Description

Given two strings text1 and text2, return the length of their longest common subsequence. If there is no common subsequence, return 0.

A subsequence of a string is a new string generated from the original string with some characters (can be none) deleted without changing the relative order of the remaining characters.

For example, "ace" is a subsequence of "abcde".
A common subsequence of two strings is a subsequence that is common to both strings.

 

Example 1:

Input: text1 = "abcde", text2 = "ace" 
Output: 3  
Explanation: The longest common subsequence is "ace" and its length is 3.
Example 2:

Input: text1 = "abc", text2 = "abc"
Output: 3
Explanation: The longest common subsequence is "abc" and its length is 3.
Example 3:

Input: text1 = "abc", text2 = "def"
Output: 0
Explanation: There is no such common subsequence, so the result is 0.
 

Constraints:

1 <= text1.length, text2.length <= 1000
text1 and text2 consist of only lowercase English characters.

# Thought Process

The problem is a classic dynamic programming problem.

The key observation is:
- If the last characters of both strings match, they contribute to the LCS.
- If they don't match, the LCS will be the longer of the LCS excluding the last/next character of text1 and the LCS excluding the last/next character of text2

In the top-down approavh dp[i,j] represents the length of the longest common subsequence starting from text1[i...] and text2[j...]. We solve the problem recursively, breaking it down into smaller subproblems.
In the Bottom-up Approach dp[i,j] represents the length of the longest common subsequence of text1[0...i-1] and text2[0...j-1]. We build our solution from smaller subproblems to larger ones.

The bottom up recurrrence is:
- If text1[i] == text2[j]: LCS[i][j] = 1 + LCS[i-1][j-1]
- Else: LCS[i][j] = max(LCS[i-1][j], LCS[i][j-1])

Complexity

- Time Complexity is O(MN)
- SPace Complexity is O(MN)

Since we only use i-1, j-1, space can be optimized


