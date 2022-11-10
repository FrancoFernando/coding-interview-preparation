public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        
        //invariant: the window shall contain at most 1 zeros
        int zeros = 0;
        int maxWinSize = 0;

        for (int j = 0, i = 0; j < nums.Length; ++j) {
        
            if (nums[j] == 0) zeros++;

            while (zeros > 1) {
                if (nums[i++] == 0) zeros--;
            }
            
            maxWinSize = Math.Max(maxWinSize, j-i+1);
        }
        return maxWinSize;
    }
}
