"""
LeetCode #78: Subsets
Difficulty: Medium
Link: https://leetcode.com/problems/subsets/
"""
from typing import List


class Solution:
    def subsets(self, nums: List[int]) -> List[List[int]]:
        def backtrack(index: int, current: List[int]):
            if index == len(nums):
                result.append(current[:])
                return

            current.append(nums[index])
            backtrack(index + 1, current)
            current.pop()
            backtrack(index + 1, current)

        result = []
        backtrack(0, [])
        return result
