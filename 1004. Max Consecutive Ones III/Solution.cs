public class Solution {
    public int LongestOnes(int[] nums, int k) {

        int maxValidSequenceLength = 0, sequenceZeros = 0;
        for (int l = 0, r = 0; r < nums.Length; ++r) {
            
            if (nums[r] == 0) sequenceZeros++;

            while (sequenceZeros > k) {
                if (nums[l++] == 0) sequenceZeros--;
            }

            maxValidSequenceLength = Math.Max(maxValidSequenceLength, r-l+1);
        }
        return maxValidSequenceLength;
    }
}
