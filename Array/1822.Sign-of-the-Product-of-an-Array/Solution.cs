public class Solution {
    public int ArraySign(int[] nums) {
        
        int negativeNums = 0;
        foreach (int num in nums) {
            if (num == 0) return 0;
            if (num < 0) negativeNums++;
        }
        return negativeNums % 2 == 0 ? 1 : -1;
    }
}
