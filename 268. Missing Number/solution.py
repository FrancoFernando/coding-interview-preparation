# set

class Solution:
    def missingNumber(self, nums: List[int]) -> int:

        unique_nums = set(nums)
        for i in range(len(nums)):
            if i not in unique_nums:
                 return i
        
        return len(nums)

# bit manipulation
class Solution:
    def missingNumber(self, nums: List[int]) -> int:

        missingNumber = len(nums)
        for i in range(len(nums)):
            missingNumber ^= nums[i]^i
        
        return missingNumber
