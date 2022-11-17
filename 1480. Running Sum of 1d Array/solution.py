# with numpy

import numpy as np

class Solution:
    def runningSum(self, nums: List[int]) -> List[int]:
        return np.cumsum(nums)
      
# classic

class Solution:
    def runningSum(self, nums: List[int]) -> List[int]:
        
        for i in range(1,len(nums)):
            nums[i] += nums[i-1]
        
        return nums
