public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        
        int maxConsecutiveOnes = 0;
        int consecutiveOnes = 0;
        
        foreach (int num in nums) {
            
            if (num == 1) {
                consecutiveOnes += 1;
                maxConsecutiveOnes = Math.Max(maxConsecutiveOnes, consecutiveOnes);
            }
            else {
                consecutiveOnes = 0;
            }          
        }
        return maxConsecutiveOnes;
    }
}
