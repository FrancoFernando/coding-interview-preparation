# Description

A peak element is an element that is strictly greater than its neighbors.

Given a 0-indexed integer array nums, find a peak element, and return its index. If the array contains multiple peaks, return the index to any of the peaks.

You may imagine that nums[-1] = nums[n] = -∞. In other words, an element is always considered to be strictly greater than a neighbor that is outside the array.

You must write an algorithm that runs in O(log n) time.

 

Example 1:

Input: nums = [1,2,3,1]
Output: 2
Explanation: 3 is a peak element and your function should return the index number 2.
Example 2:

Input: nums = [1,2,1,3,5,6,4]
Output: 5
Explanation: Your function can return either index number 1 where the peak element is 2, or index number 5 where the peak element is 6.
 

Constraints:

1 <= nums.length <= 1000
-231 <= nums[i] <= 231 - 1
nums[i] != nums[i + 1] for all valid i.

# Thought Process

The brute force approach is the linear search solution, which is to examine each num and compare it with its two neighbours.

But the straightforward linear scan solution isn't using all of the clues given in the question. These clues, including

- No adjacent two numbers are the same
- the two end of the arrays are -∞
- You can return any peak.

If you use all these clues you can com  to binary search. Binary search has two important aspects.

- A sorted array.
- Splitting an array into two halves.
- 
We do not have the first one here. Let us think about the second point. This requires a little brainstroming.

If the mid element is the local maximum. Return.

But if it isn't, and no two adjacent elements are equal, then either of the elements (or maybe both of them) will be greater than the mid element.

Now whichever side has the greater element, you can go to that side and continue the same process.

Why, you ask ?

Let us say, the element at [mid+1] is greater.

Both extremes have numbers smaller than the edge numbers - the right end is already given in the question, and the left end has just been checked by you. 
That means we can certainly find a local maximum in the right array.

# Complexity

O(logN) time and O(1) space
