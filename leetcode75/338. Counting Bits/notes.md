# Description

Given an integer n, return an array ans of length n + 1 such that for each i (0 <= i <= n), ans[i] is the number of 1's in the binary representation of i.

Example 1:

Input: n = 2
Output: [0,1,1]
Explanation:
0 --> 0
1 --> 1
2 --> 10
Example 2:

Input: n = 5
Output: [0,1,1,2,1,2]
Explanation:
0 --> 0
1 --> 1
2 --> 10
3 --> 11
4 --> 100
5 --> 101
 

Constraints:

0 <= n <= 105
 

Follow up:

It is very easy to come up with a solution with a runtime of O(n log n). Can you do it in linear time O(n) and possibly in a single pass?
Can you do it without using any built-in function (i.e., like __builtin_popcount in C++)?

# Thought process

The brute force approach is easy: for each number from 0 to n, convert it to binary and count the 1's.
To convert a number to binary:
- Repeatedly divide by 2
- Keep track of the remainders (0 or 1)
- The remainders in reverse order give the binary representation

The optimal approach is based on two observations.

Observation 1: binary representations follow a pattern:
0 (0) -> 0
1 (1) -> 1
2 (10) -> 1
3 (11) -> 2
4 (100) -> 1
5 (101) -> 2
6 (110) -> 2
7 (111) -> 3

Observation 2: When we reach a power of 2, the count resets to 1 and then follows the previous pattern plus 1.

If x is even: bits(x) = bits(x/2)
If x is odd: bits(x) = bits(x/2) + 1

# Complexity

- O(nlgn) for the brute force (conversion to binary is O(lgn) for each number
- O(n) for the optimal approach
