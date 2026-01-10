"""
LeetCode #40: Combination Sum II
Difficulty: Medium
Link: https://leetcode.com/problems/combination-sum-ii/
"""
from typing import List


class Solution:
    def combinationSum2(self, candidates: List[int], target: int) -> List[List[int]]:
        result = []
        candidates.sort()

        def backtrack(start: int, current: List[int], remaining: int):
            if remaining == 0:
                result.append(current[:])
                return

            for i in range(start, len(candidates)):
                # Skip duplicates at the same level
                if i > start and candidates[i] == candidates[i - 1]:
                    continue
                if candidates[i] > remaining:
                    break
                current.append(candidates[i])
                backtrack(i + 1, current, remaining - candidates[i])
                current.pop()

        backtrack(0, [], target)
        return result
