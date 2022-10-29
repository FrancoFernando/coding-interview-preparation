public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        
        int w = m+n-1;
        m = m-1;
        n = n-1;

        while (m >= 0 && n >= 0) {
            nums1[w--] = (nums1[m] > nums2[n]) ? nums1[m--] : nums2[n--];
        }

        //if m >= 0, nums1 elements are already placed
        while (n >= 0) {
            nums1[w--] = nums2[n--];
        }
    }
}
