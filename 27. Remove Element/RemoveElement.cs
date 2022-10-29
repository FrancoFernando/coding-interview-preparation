public class Solution {
    public int RemoveElement(int[] nums, int val) {
        
        int removedElements = 0;
        for (int i = 0; i < nums.Length; ++i) {

            if (nums[i] == val) {
                removedElements++;
            }
            else {
                nums[i-removedElements] = nums[i];
            }
        }
        return nums.Length-removedElements;
    }
}
