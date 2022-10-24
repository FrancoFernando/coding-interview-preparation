class Solution:
    def findMaxConsecutiveOnes(self, nums: List[int]) -> int:

        maxConsecutiveOnes = 0
        consecutiveOnes = 0
        
        for num in nums:
            
            if num == 1:
                consecutiveOnes += 1
                maxConsecutiveOnes = max(maxConsecutiveOnes, consecutiveOnes)
            else:
                consecutiveOnes = 0

        return maxConsecutiveOnes
