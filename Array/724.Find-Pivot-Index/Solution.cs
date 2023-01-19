public class Solution {
    public int PivotIndex(int[] nums) {
        
        int prefixSum = 0, postfixSum = nums.Sum();

        for (int i = 0; i < nums.Length; ++i) {
            postfixSum -= nums[i];
            if (prefixSum == postfixSum) return i;
            prefixSum += nums[i];
        }

        return -1;
    }
}
