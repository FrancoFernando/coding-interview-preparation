public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int minLength = int.MaxValue;
        for(int right = 0, left = 0, sum = 0; right < nums.Length; right++){
             sum += nums[right];
             while (sum >= target) {
                minLength = Math.Min(minLength, right-left+1);
                sum -= nums[left++];
             }
        }
        return minLength == int.MaxValue ? 0 : minLength;
    }
}
