class Solution:
    def checkIfExist(self, arr: List[int]) -> bool:
        
        # Corner case 0*2 = 0
        if arr.count(0) > 1:
            return True
        
        unique_numbers = set(arr)

        for num in unique_numbers:
            if num*2 in unique_numbers and num != 0:
                return True

        return False
