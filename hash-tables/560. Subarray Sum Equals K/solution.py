class Solution:
    def subarraySum(self, nums: List[int], k: int) -> int:
        count = {0: 1}
        curr_sum = 0
        result = 0
        
        for num in nums:
            curr_sum += num
            if curr_sum - k in count:
                result += count[curr_sum - k]
            count[curr_sum] = count.get(curr_sum, 0) + 1
        
        return result
