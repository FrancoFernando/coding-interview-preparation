class Solution:
    def validMountainArray(self, arr: List[int]) -> bool:
        
        peak = max(arr)
        peakIdx = arr.index(peak)

        if peakIdx >= len(arr)-1 or peakIdx == 0:
            return False

        for prevNum, num in zip(arr[:peakIdx],arr[1:peakIdx+1]):
            if num <= prevNum:
                return False

        for prevNum, num in zip(arr[peakIdx:-1],arr[peakIdx+1:]):
            if num >= prevNum:
                return False

        return True
