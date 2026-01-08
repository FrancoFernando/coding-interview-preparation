"""
LeetCode #560: Subarray Sum Equals K
Difficulty: Medium
Link: https://leetcode.com/problems/subarray-sum-equals-k/
"""
from typing import List


class Solution:
    def subarraySum(self, nums: List[int], k: int) -> int:
        count = {0: 1}
        curr_sum = 0
        result = 0

        for num in nums:
            curr_sum += num
            if curr_sum - k in count:
                result += count[curr_sum - k]
            count[curr_sum] = count.get(curr_sum, 0) + 1

        return result


def test_solution():
    sol = Solution()
    assert sol.subarraySum([1, 1, 1], 2) == 2
    assert sol.subarraySum([1, 2, 3], 3) == 2
    print("All tests passed!")


if __name__ == "__main__":
    test_solution()
