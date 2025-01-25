# Description

Given 3 positives numbers a, b and c. Return the minimum flips required in some bits of a and b to make ( a OR b == c ). (bitwise OR operation).
Flip operation consists of change any single bit 1 to 0 or change the bit 0 to 1 in their binary representation.

 

Example 1:



Input: a = 2, b = 6, c = 5
Output: 3
Explanation: After flips a = 1 , b = 4 , c = 5 such that (a OR b == c)
Example 2:

Input: a = 4, b = 2, c = 7
Output: 1
Example 3:

Input: a = 1, b = 2, c = 3
Output: 0
 

Constraints:

1 <= a <= 10^9
1 <= b <= 10^9
1 <= c <= 10^9

# Thought process

There is nothing fancy here. You only need to check bit by bit c and see if a and b need to be flipped.
If the last bit of a or the last bit of b is different from the last bit of c there are two possibiities:
1. c = 1 => a,b=0,0 one flip is enough
2. c = 0 => a,b=1,1 or 1,0 or 0,1 flips can be 1 or 2

# Complexity

O(log(max(a,b,c))) time since every time we divide by two, O(1) space
