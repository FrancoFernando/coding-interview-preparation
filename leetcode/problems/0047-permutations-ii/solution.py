"""
LeetCode #47: Permutations II
Difficulty: Medium
Link: https://leetcode.com/problems/permutations-ii/
"""
from typing import List


class Solution:
    def permuteUnique(self, nums: List[int]) -> List[List[int]]:
        result = []
        used = [False] * len(nums)
        nums.sort()

        def backtrack(current: List[int]):
            if len(current) == len(nums):
                result.append(current[:])
                return

            seen = set()
            for i in range(len(nums)):
                if used[i] or nums[i] in seen:
                    continue
                seen.add(nums[i])
                used[i] = True
                current.append(nums[i])
                backtrack(current)
                current.pop()
                used[i] = False

        backtrack([])
        return result
