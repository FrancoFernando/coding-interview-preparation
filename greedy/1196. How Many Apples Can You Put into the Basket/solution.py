class Solution:
    def maxNumberOfApples(self, weight: List[int]) -> int:
        cumulative_weights = list(accumulate(sorted(weight)))
        
        for i, total_weight in enumerate(cumulative_weights):
            if total_weight > 5000:
                return i
        
        return len(weight)
