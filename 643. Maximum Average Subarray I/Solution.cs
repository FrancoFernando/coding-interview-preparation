public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        
        int sumInsideWindow = nums.Take(k).Sum();
        int maxSumInsideWindow = sumInsideWindow;

        for (int i = k; i < nums.Length; ++i) {
            sumInsideWindow += (nums[i]-nums[i-k]);
            maxSumInsideWindow = Math.Max(maxSumInsideWindow, sumInsideWindow);
        }

        return maxSumInsideWindow / (double)k;
    }
}
