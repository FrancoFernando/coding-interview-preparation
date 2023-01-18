public class Solution {
    public int PivotIndex(int[] nums) {
        
        var prefixSum = new int[nums.Length+2];

        for (int i = 1; i <= nums.Length; ++i) {
            prefixSum[i] = prefixSum[i-1] + nums[i-1]; 
        }

        for (int i = 1; i <= nums.Length; ++i) {
            if (prefixSum[i-1] == prefixSum[nums.Length]-prefixSum[i]) {
                return i-1;
            }
        }

        return -1;
    }
}

//Optimized: need only total sum, and sumleft, no need of additional O(N) space
