# Description

Given an array of integers nums and an integer k, return the total number of subarrays whose sum equals to k.

A subarray is a contiguous non-empty sequence of elements within an array.

Example 1:

Input: nums = [1,1,1], k = 2
Output: 2
Example 2:

Input: nums = [1,2,3], k = 3
Output: 2
 
Constraints:

1 <= nums.length <= 2 * 104
-1000 <= nums[i] <= 1000
-107 <= k <= 107

# Thought process

Brute force is to check each subarray, calculate its sum and see if it's equal to k. O(nˆ3)
Optimization is to precalculate prefix sums to do the check. O(nˆ2)
Optimal solution comes from observing that Prefix[j]-Prefix[i] = k => Prefix[j] - k = Prefix[i]
If prefix[i] was already found increase the resut by how many times. Prefixes can be stored in a hash table counting frequencies.

# Complexity

Time complexity is O(N) and also space complexity to store the hash map.
