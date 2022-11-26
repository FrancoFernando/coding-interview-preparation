public class Solution {
    public int NumSubarrayProductLessThanK(int[] nums, int k) {
        
        int numValidSubarrays = 0;

        for (int l = 0, r = 0, product = 1; r < nums.Length; ++r) {

            product *= nums[r];
            while (product >= k && l <= r) {
                product /= nums[l++];
            }
            numValidSubarrays += r-l+1;
        }

        return numValidSubarrays;
    }
}
