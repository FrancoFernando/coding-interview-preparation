class Solution:
    def removeElement(self, nums: List[int], val: int) -> int:

        removedElements = 0

        for index, num in enumerate(nums):
            if num == val:
                removedElements += 1
            else:
                nums[index-removedElements] = num
            
        return len(nums)-removedElements
Console
