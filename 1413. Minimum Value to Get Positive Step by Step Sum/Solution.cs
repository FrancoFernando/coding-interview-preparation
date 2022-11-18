public class Solution {
    public int MinStartValue(int[] nums) {
        
        int minValue = 0, cumSum = 0;

        foreach (int num in nums) {

            cumSum += num;
            minValue = Math.Min(minValue, cumSum);
        }

        return -minValue + 1;
    }
}
