public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        var numToIndex = new Dictionary<int,int>();

        for (int i = 0; i < nums.Length; ++i) {

            if (numToIndex.TryGetValue(target - nums[i], out int index)) {
                return new int[]{index, i};
            }
            numToIndex[nums[i]] = i;
        }
        return new int[2]{-1,-1};
    }
}
