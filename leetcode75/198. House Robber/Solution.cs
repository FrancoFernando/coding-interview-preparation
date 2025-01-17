public class Solution {
    public int Rob(int[] nums) {
        if (nums.Length == 1)
            return nums[0];

        int prevMax = 0, currMax = nums[0];

        for (int i = 1; i < nums.Length; ++i) {
            int tmp = currMax;
            currMax = Math.Max(nums[i] + prevMax, currMax);
            prevMax = tmp;

        }
        return currMax;
    }
}
