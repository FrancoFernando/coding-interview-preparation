public class Solution {
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2) {
        return new List<IList<int>>() {
            nums1.Except(nums2).ToList(),
            nums2.Except(nums1).ToList()
        };
    }
}
//Except convert the second argument to a hashset
