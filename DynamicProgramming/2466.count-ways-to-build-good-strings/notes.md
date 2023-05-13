## Description

Given the integers zero, one, low, and high, we can construct a string by starting with an empty string, and then at each step perform either of the following:

Append the character '0' zero times.
Append the character '1' one times.
This can be performed any number of times.

A good string is a string constructed by the above process having a length between low and high (inclusive).

Return the number of different good strings that can be constructed satisfying these properties. Since the answer can be large, return it modulo 109 + 7.

Example 1:

Input: low = 3, high = 3, zero = 1, one = 1
Output: 8
Explanation: 
One possible valid good string is "011". 
It can be constructed as follows: "" -> "0" -> "01" -> "011". 
All binary strings from "000" to "111" are good strings in this example.
Example 2:

Input: low = 2, high = 3, zero = 1, one = 2
Output: 5
Explanation: The good strings are "00", "11", "000", "110", and "011".
 
Constraints:

1 <= low <= high <= 105
1 <= zero, one <= low

## Thinking process

The first thing to understand is that is not necessary to build the strings.
When you get to a string of length L it doesn't matter how you get there, you need to count the good string that you can build starting from there.

So at each step you have 3 possibilities:
- you have a string of length between low and high, so you add 1 to the number of good strings and try to build other good strings
- you build a new string with the current length+zero
- you build a new string with the current length+one

The recursive formulation is straightforward. Since there are multiple ways to build a string of lenght L, caching results with memoization is necessary.

## Complexity

* O(high) time
* O(high) space
