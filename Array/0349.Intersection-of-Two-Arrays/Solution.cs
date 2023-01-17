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

//LINQ
//LINQ intersect, when comparing to collections, builds a hashset with one and then iterates over the other, with a time complexity of O(N + M). 
public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        return nums1.Intersect(nums2).ToArray();
    }
}
