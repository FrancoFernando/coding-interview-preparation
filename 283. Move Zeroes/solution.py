class Solution:
    def moveZeroes(self, nums: List[int]) -> None:
        """
        Do not return anything, modify nums in-place instead.
        """
        zeroes = 0

        for index, num in enumerate(nums):

            if num == 0:
                zeroes += 1
            else:
                nums[index-zeroes] = num

        nums[len(nums)-zeroes:] = [0] * zeroes
