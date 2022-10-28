class Solution:
    def duplicateZeros(self, arr: List[int]) -> None:
        """
        Do not return anything, modify arr in-place instead.
        """
        shift = arr.count(0)
        
        for i in range(len(arr)-1,-1,-1):

            if arr[i] == 0:
                shift -= 1
                if i+shift+1 < len(arr):
                    arr[i+shift+1] = 0

            if i+shift < len(arr):
                arr[i+shift] = arr[i]
