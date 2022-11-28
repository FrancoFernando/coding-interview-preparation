public class Solution {
    public int LargestUniqueNumber(int[] nums) {
        
        const int maxNumber = 1000;
        var frequencies = new int[maxNumber+1];
        
        foreach (int num in nums) frequencies[num]++;

        return Array.LastIndexOf(frequencies, 1);
    }
}
