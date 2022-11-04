public class Solution {
    public int[] SortArrayByParity(int[] nums) {

        // invariants: 
        // 1. all elements on the right of j are odd
        // 2. all elements to the left of i ar even

        int i = 0, j = nums.Length-1;

        while (i < j) {

            if (nums[i] % 2 == 0) {
                i++;
            }
            else if (nums[j] % 2 != 0) {
                j--;
            }
            else {
                (nums[i], nums[j]) = (nums[j], nums[i]);
                i++;
                j--;
            }
        }
        return nums;
    }
}
