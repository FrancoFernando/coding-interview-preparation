"""
LeetCode #967: Numbers With Same Consecutive Differences
Difficulty: Medium
Link: https://leetcode.com/problems/numbers-with-same-consecutive-differences/
"""
from typing import List


class Solution:
    def numsSameConsecDiff(self, n: int, k: int) -> List[int]:
        result = []

        def backtrack(num: int, length: int):
            if length == n:
                result.append(num)
                return

            last_digit = num % 10

            # Try adding digit + k
            if last_digit + k <= 9:
                backtrack(num * 10 + last_digit + k, length + 1)

            # Try adding digit - k (avoid duplicates when k == 0)
            if k != 0 and last_digit - k >= 0:
                backtrack(num * 10 + last_digit - k, length + 1)

        # Start with digits 1-9 (no leading zeros)
        for digit in range(1, 10):
            backtrack(digit, 1)

        return result
