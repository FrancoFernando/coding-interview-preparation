class Solution:
    def sortArrayByParity(self, nums: List[int]) -> List[int]:

        # invariants: 
        # 1. all elements on the right of j are odd
        # 2. all elements to the left of i ar even

        i, j = 0, len(nums)-1

        while i < j:

            if nums[i] % 2 == 0:
                i += 1
            elif nums[j] % 2 != 0:
                j -= 1
            else:
                nums[i], nums[j] = nums[j], nums[i]

        return nums
