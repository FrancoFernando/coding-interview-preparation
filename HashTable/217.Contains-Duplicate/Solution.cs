public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        
        var alreadySeenNums = new HashSet<int>();

        foreach (int num in nums) {
            if (alreadySeenNums.Contains(num)) return true;
            alreadySeenNums.Add(num);
        }
        return false;
    }
}
