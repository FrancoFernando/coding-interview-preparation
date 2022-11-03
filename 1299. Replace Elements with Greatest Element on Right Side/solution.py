class Solution:
    def replaceElements(self, arr: List[int]) -> List[int]:

        greatestValue = -1
        
        for index in range(len(arr)-1,-1,-1):
            newValue = greatestValue
            greatestValue = max(greatestValue, arr[index])
            arr[index] = newValue
        
        return arr
