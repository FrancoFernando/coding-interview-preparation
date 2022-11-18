class Solution:
    def minStartValue(self, nums: List[int]) -> int:

        minValue, cumSum = 0, 0

        for num in nums:

            cumSum += num
            minValue = min(minValue, cumSum)

        return -minValue + 1
