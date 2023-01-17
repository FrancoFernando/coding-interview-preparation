public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        
        var canBeInIntersection = new bool[1001];
        var intersection = new List<int>();

        foreach (int num in nums1) canBeInIntersection[num] = true;

        foreach (int num in nums2) {
            if (canBeInIntersection[num]) {
                intersection.Add(num);
                canBeInIntersection[num] = false;
            }
        }

        return intersection.ToArray();
    }
}
