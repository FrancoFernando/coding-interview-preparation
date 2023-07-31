public class Solution {
    public int[] SortedSquares(int[] nums) {
        
        int[] output = new int[nums.Length];
        
        int l = 0, r = nums.Length-1, w = r; 
        
        while (l <= r) {
            
            if (Math.Abs(nums[l]) > Math.Abs(nums[r])) {
                output[w--] = nums[l]*nums[l];
                l++;
            }
            else {
                output[w--] = nums[r]*nums[r];
                r--;
            }
              
        }
        return output;
    }
}
