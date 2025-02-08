class Solution:
    def canPlaceFlowers(self, flowerbed: List[int], n: int) -> bool:

        if n == 0:
            return True

        length = len(flowerbed)

        for i in range(length):

            if flowerbed[i] == 1:
                continue
            
            is_left_empty = (i == 0) or (flowerbed[i - 1] == 0)
            is_right_empty = (i == length - 1) or (flowerbed[i + 1] == 0)

            if is_left_empty and is_right_empty:
                n -= 1
                flowerbed[i] = 1
                if n == 0:
                    return True

        return False
