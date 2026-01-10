"""
LeetCode #216: Combination Sum III
Difficulty: Medium
Link: https://leetcode.com/problems/combination-sum-iii/
"""
from typing import List


class Solution:
    def combinationSum3(self, k: int, n: int) -> List[List[int]]:
        result = []

        def backtrack(start: int, current: List[int], remaining: int):
            if len(current) == k:
                if remaining == 0:
                    result.append(current[:])
                return

            for num in range(start, 10):
                if num > remaining:
                    break
                current.append(num)
                backtrack(num + 1, current, remaining - num)
                current.pop()

        backtrack(1, [], n)
        return result
