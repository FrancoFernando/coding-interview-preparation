class Solution:
    def removeDuplicates(self, nums: List[int]) -> int:

        duplicates = 0

        for index, num in enumerate(nums[1:],1):

            if num == nums[index-1]:
                duplicates += 1
            else:
                nums[index-duplicates] = num

        return len(nums)-duplicates
