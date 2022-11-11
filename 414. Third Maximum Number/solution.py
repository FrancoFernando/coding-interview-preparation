import sortedcontainers

class Solution:
    def thirdMax(self, nums: List[int]) -> int:

        maxNums = sortedcontainers.SortedSet()

        for num in nums: 
            maxNums.add(num)
            if len(maxNums) > 3: 
                maxNums.pop(0)
    
        return maxNums[-1] if (len(maxNums) < 3) else maxNums[0]
