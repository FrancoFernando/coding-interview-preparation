# Description

Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.

Note that you must do this in-place without making a copy of the array.

 

Example 1:

Input: nums = [0,1,0,3,12]
Output: [1,3,12,0,0]
Example 2:

Input: nums = [0]
Output: [0]
 

Constraints:

1 <= nums.length <= 104
-231 <= nums[i] <= 231 - 1
 

Follow up: Could you minimize the total number of operations done?

# Thought process

Keep an index for non-zero elements and use it to place non-zero numbers while iterating the input array. 
Pad the remaining elements with zeros.

# Complexity
The  time complexity is O(n), the space complexity remains O(1) as we're modifying the array in-place without using any additional data structures.
