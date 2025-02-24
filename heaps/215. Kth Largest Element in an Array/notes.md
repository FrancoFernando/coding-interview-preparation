# Description

Given an integer array nums and an integer k, return the kth largest element in the array.

Note that it is the kth largest element in the sorted order, not the kth distinct element.

Can you solve it without sorting?

 

Example 1:

Input: nums = [3,2,1,5,6,4], k = 2
Output: 5
Example 2:

Input: nums = [3,2,3,1,2,4,5,5,6], k = 4
Output: 4
 

Constraints:

1 <= k <= nums.length <= 105
-104 <= nums[i] <= 104

# Thought process

The idea is to use a minHeap to store the largest k numbers. Every time a numbers is greater than the smallest int the heao, remove the smallest and insert the new one.

# Complexity

Time complexity is O(NlogK) to insert N numbers into a heap of size K.
Space complexity is O(K) for the heap.
