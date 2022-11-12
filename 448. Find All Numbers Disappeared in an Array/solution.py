class Solution:
    def findDisappearedNumbers(self, nums: List[int]) -> List[int]:

        for num in nums:
            positiveNum = abs(num)
            if nums[positiveNum-1] > 0:
                nums[positiveNum-1] *= -1
        

        disappearedNums = []

        for i in range(len(nums)):
            if nums[i] > 0:
                disappearedNums.append(i+1)
        
        return disappearedNums
