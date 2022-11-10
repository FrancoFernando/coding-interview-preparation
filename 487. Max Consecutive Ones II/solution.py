class Solution:
    def findMaxConsecutiveOnes(self, nums: List[int]) -> int:

        # invariant: the window shall contain at most 1 zeros
        zeros, maxWinSize, i = 0, 0, 0

        for j in range(len(nums)):
        
            if nums[j] == 0 :
                zeros += 1

            while zeros > 1:
                if nums[i] == 0: 
                    zeros -= 1
                i += 1
                
            maxWinSize = max(maxWinSize, j-i+1)
        
        return maxWinSize
