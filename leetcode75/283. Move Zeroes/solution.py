class Solution:
    def moveZeroes(self, nums: List[int]) -> None:
        """
        Do not return anything, modify nums in-place instead.
        """
        non_zero_index = 0
        
        # Move all non-zero elements to the front
        for num in nums:
            if num != 0:
                nums[non_zero_index] = num
                non_zero_index += 1
        
        # Fill the rest with zeroes
        nums[non_zero_index:] = [0] * (len(nums) - non_zero_index)
