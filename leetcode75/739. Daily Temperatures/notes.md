# Description

Given an array of integers temperatures represents the daily temperatures, return an array answer such that answer[i] is the number of days you have to wait after the ith day to get a warmer temperature. If there is no future day for which this is possible, keep answer[i] == 0 instead.

Example 1:

Input: temperatures = [73,74,75,71,69,72,76,73]
Output: [1,1,4,2,1,1,0,0]
Example 2:

Input: temperatures = [30,40,50,60]
Output: [1,1,1,0]
Example 3:

Input: temperatures = [30,60,90]
Output: [1,1,0]
 

Constraints:

1 <= temperatures.length <= 105
30 <= temperatures[i] <= 100

# Thought Process

The brute force is: for each day, look at all future days until a warmer day is found. This would be O(n^2) time complexity, which is inefficient for large inputs.

Notice that we're looking for the "next greater element" for each temperature. The only way to know this in advance is to iterate backwards. 

If we iterate backward the problem becomes can be the current temperature a warmer day for some previous day?

The current temperature can always be a possible warmer day for the previous one. But all the temperatures we have already seen that are <= than the current one cannot anymore and can be discarded.

A stack containing monotonically increasing temperatures is the perfect data structure for this task.


# Complexity

O(N) time to iterate the temperatures and O(N) space for the stack
