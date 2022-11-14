class Solution:
    def findMaxAverage(self, nums: List[int], k: int) -> float:

        sumInsideWindow = sum(nums[0:k])
        maxSumInsideWindow = sumInsideWindow

        for i in range(k,len(nums)):
            sumInsideWindow += (nums[i]-nums[i-k])
            maxSumInsideWindow = max(maxSumInsideWindow, sumInsideWindow)

        return maxSumInsideWindow / k
