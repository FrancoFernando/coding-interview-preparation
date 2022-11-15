class Solution:
    def longestOnes(self, nums: List[int], k: int) -> int:

        maxValidSequenceLength, sequenceZeros, l = 0, 0, 0
        for r, num in enumerate(nums):

            if num == 0:
                sequenceZeros += 1

            while sequenceZeros > k:
                if nums[l] == 0:
                    sequenceZeros -= 1
                l += 1    

            maxValidSequenceLength = max(maxValidSequenceLength, r-l+1)
        
        return maxValidSequenceLength
