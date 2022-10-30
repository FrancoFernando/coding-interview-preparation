public class Solution {
    public bool ValidMountainArray(int[] arr) {

        var (peak, peakIdx) = arr.Select((n, i) => (n, i)).Max();

        if (peakIdx >= arr.Length-1 || peakIdx == 0) return false;

        for (int i = 1; i <= peakIdx; ++i) {
            if (arr[i] <= arr[i-1]) return false;
        }

        for (int i = peakIdx+1; i < arr.Length; ++i) {
            if (arr[i] >= arr[i-1]) return false;
        }

        return true;
    }
}
