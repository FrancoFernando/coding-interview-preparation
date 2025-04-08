class Solution:
    def subsets(self, nums: List[int]) -> List[List[int]]:
        def backtrack(index, current):
            if index == len(nums):
                result.append(current[:])
                return
            
            current.append(nums[index])
            backtrack(index + 1, current)
            current.pop()
            backtrack(index + 1, current)
    
        result = []
        backtrack(0, [])
        return result
