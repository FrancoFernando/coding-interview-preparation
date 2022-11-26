class Solution:
    def numSubarrayProductLessThanK(self, nums: List[int], k: int) -> int:

        l, numValidSubarrays, product = 0, 0, 1

        for r, num in enumerate(nums):

            product *= num
            while product >= k and l <= r:
                product /= nums[l]
                l += 1
            
            numValidSubarrays += r-l+1

        return numValidSubarrays
