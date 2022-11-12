public class Solution {
    public IList<int> FindDisappearedNumbers(int[] nums) {

        foreach (int num in nums) {
            int positiveNum = Math.Abs(num);
            if (nums[positiveNum-1] > 0) nums[positiveNum-1] *= -1;
        }

        var disappearedNums = new List<int>();

        for (int i = 0; i < nums.Length; ++i) {
            if (nums[i] > 0) disappearedNums.Add(i+1);
        }
        return disappearedNums;
    }
}
