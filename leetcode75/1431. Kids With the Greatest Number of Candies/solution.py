class Solution:
    def kidsWithCandies(self, candies: List[int], extraCandies: int) -> List[bool]:

        max_candies = max(candies)
        return [curr_candies + extraCandies >= max_candies for curr_candies in candies]
