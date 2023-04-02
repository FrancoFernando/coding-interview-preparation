### Description

Given two strings s1 and s2, return true if s2 contains a permutation of s1, or false otherwise.

In other words, return true if one of s1's permutations is the substring of s2.

Example 1:

Input: s1 = "ab", s2 = "eidbaooo"
Output: true
Explanation: s2 contains one permutation of s1 ("ba").
Example 2:

Input: s1 = "ab", s2 = "eidboaoo"
Output: false
 
Constraints:

1 <= s1.length, s2.length <= 104
s1 and s2 consist of lowercase English letters.

### Thinking Process

The brute force solution would be to find all permutations of s1 and compare them to all possible substrings s2 to see if they’re equal. The approach is not feasible for large strings because its time complexity would be factorial in the length of the string.

The key observation to find a better solution is that a string is a permutation of another string if both use the same characters with the same frequencies. With this in mind, the approach become straightforward:

* count the frequencies of the letters in s1

* run a sliding windows in s2 with the size of s1 and count the frequencies of the letters in the windows

* check if the frequencies of the letters in s1 and in the window are equal

### Complexity

* The time complexity is O(NA), where N is the size of s2 and A is the size of the alphabet
* The space complexity is O(A)

