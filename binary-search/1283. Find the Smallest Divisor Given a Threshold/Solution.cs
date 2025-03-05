public class Solution {
    public int SmallestDivisor(int[] nums, int threshold) {
        
        int left = 1, right = nums.Max();

        while (left < right) {

            int mid = (left + right) / 2;
            if (SumOfDivisions(nums, mid) <= threshold) {
                right = mid;
            }
            else {
                left = mid + 1;
            }
        }
        return left;
    }

    private int SumOfDivisions(int[] nums, int divisor) {
        // ceiling withou floating points
        return nums.Sum(n => (n + divisor - 1) / divisor);
    }
}
