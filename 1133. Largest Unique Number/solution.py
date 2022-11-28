# with counter
class Solution:
    def largestUniqueNumber(self, nums: List[int]) -> int:
        
        frequencies = collections.Counter(nums)
        unique_numbers = [key for key in frequencies.elements() if frequencies[key] == 1]
        return max(unique_numbers) if unique_numbers else -1

# traditional
class Solution:
    def largestUniqueNumber(self, nums: List[int]) -> int:
        
        maxNumber = 1000
        frequencies = [0]*(maxNumber+1)
        
        for num in nums:
            frequencies[num] += 1
            
        largestUnique = -1
        
        for index, frequency in enumerate(frequencies):
            if (frequency == 1): 
                largestUnique = index
                
        return largestUnique
            
            
Console
