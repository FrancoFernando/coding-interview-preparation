class Solution:
    def heightChecker(self, heights: List[int]) -> int:

        max_height = 101
        different_heights = 0
        heights_counter = [0]*max_height

        for height in heights:
             heights_counter[height] +=1
        
        h = 0
        for i in range(max_height):
            for j in range(heights_counter[i]):
                if heights[h] != i:
                    different_heights += 1
                h += 1

        return different_heights
