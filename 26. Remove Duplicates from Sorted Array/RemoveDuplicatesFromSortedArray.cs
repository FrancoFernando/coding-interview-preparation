public class Solution {
    public int RemoveDuplicates(int[] nums) {
        
        int duplicates = 0;

        for (int i = 1; i < nums.Length; ++i) {

            if (nums[i] == nums[i-1]) {
                duplicates++;
            }
            else {
                nums[i-duplicates] = nums[i];
            }
        }
        return nums.Length-duplicates;
    }
}
