public class Solution {
    public void MoveZeroes(int[] nums) {
        
        int zeroes = 0;

        for (int i = 0; i < nums.Length; ++i) {

            if (nums[i] == 0) {
                zeroes++;
            }
            else {
                nums[i-zeroes] = nums[i];
            }
        }

        for (int i = nums.Length-zeroes; i < nums.Length; ++i) {
            nums[i] = 0;
        }
    }
}
