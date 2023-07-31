class Solution:
    def sortedSquares(self, nums: List[int]) -> List[int]:
        
        l, r, w = 0, len(nums)-1, len(nums)-1
        output = [0]*len(nums)
        
        while l <= r:
            
            if abs(nums[l]) > abs(nums[r]):
                output[w] = pow(nums[l],2)
                l += 1;
            else:
                output[w] = pow(nums[r],2)
                r -= 1
            
            w -= 1
        
        return output
