public class Solution {
    public void MoveZeroes(int[] nums) {
        
        int nonZeroIndex = 0;

        for (int i = 0; i < nums.Length; ++i) {
            if (nums[i] != 0) {
                nums[nonZeroIndex++] = nums[i];
            }
        }

        for (int i = nonZeroIndex; i < nums.Length; ++i) {
            nums[i] = 0;
        }
    }
}
