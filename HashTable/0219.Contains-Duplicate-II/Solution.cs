public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        
        var nearbyNums = new HashSet<int>();

        for (int i = 0; i < nums.Length; ++i) {
            
            if (nearbyNums.Contains(nums[i])) return true;
            // the order of the next 2 lines is important to handle the case k = 0
            nearbyNums.Add(nums[i]);   
            if (i >= k) nearbyNums.Remove(nums[i-k]);
        }
        return false;
    }
}
