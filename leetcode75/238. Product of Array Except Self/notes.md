# Description

Given an integer array nums, return an array answer such that answer[i] is equal to the product of all the elements of nums except nums[i].

The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.

You must write an algorithm that runs in O(n) time and without using the division operation.

 

Example 1:

Input: nums = [1,2,3,4]
Output: [24,12,8,6]
Example 2:

Input: nums = [-1,1,0,-3,3]
Output: [0,0,9,0,0]
 

Constraints:

2 <= nums.length <= 105
-30 <= nums[i] <= 30
The input is generated such that answer[i] is guaranteed to fit in a 32-bit integer.
 

Follow up: Can you solve the problem in O(1) extra space complexity? (The output array does not count as extra space for space complexity analysis.)

# Thought process

The solution is quite straightforward. First calculate the product of all elements to the left of each element (forward iteration).
Then, in a second pass, multiplying each element by the product of all elements to its right (backward iteration).

# Complexity

The time complexity is O(n), where n is the length of the input array. The space complexity is O(1), as we're not using any extra space that scales with the input size.
