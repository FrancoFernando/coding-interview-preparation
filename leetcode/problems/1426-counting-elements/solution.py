"""
LeetCode #1426: Counting Elements
Difficulty: Easy
Link: https://leetcode.com/problems/counting-elements/
"""
from typing import List


class Solution:
    def countElements(self, arr: List[int]) -> int:
        nums = set(arr)
        count = 0
        for x in arr:
            if x + 1 in nums:
                count += 1
        return count


def test_solution():
    sol = Solution()
    assert sol.countElements([1, 2, 3]) == 2
    assert sol.countElements([1, 1, 3, 3, 5, 5, 7, 7]) == 0
    print("All tests passed!")


if __name__ == "__main__":
    test_solution()
