public class Solution {
    public int FindPeakElement(int[] nums) {
        int left = 0, right = nums.Length - 1;

        while (left < right) {
            int mid = left + (right - left) / 2;
            if (nums[mid] < nums[mid + 1]) {
                left = mid + 1;
            } else {
                right = mid;
            }
        }

        return left;
    }
}


// In the solution below I explicitely checked if the mid is the PeakElement.
// But this is unncessary since binary search will naturally converge to a peak element
public class Solution {
    public int FindPeakElement(int[] nums) {
        int left = 0, right = nums.Length-1;

        while (left <= right) {
            int mid = left + (right - left) / 2;
            if (Isx(nums, mid)) {
                return mid;
            }
            else if (nums[mid + 1] > nums[mid]) {
                left = mid + 1;
            }
            else {
                right = mid - 1;
            }
        }
        // never reach this point
        return -1;
    }

    private bool IsPeakElement(int[] nums, int index) {
        long leftElement = index == 0 ? Int64.MinValue : nums[index-1];
        long rightElement = index == nums.Length-1 ? Int64.MinValue : nums[index+1];
        return nums[index] > leftElement && nums[index] > rightElement;
    }
