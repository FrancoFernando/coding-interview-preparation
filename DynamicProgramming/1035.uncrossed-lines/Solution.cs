public class Solution {

    // max number of uncrossed lines after indexes i,j
    int [,] dp;

    public int MaxUncrossedLines(int[] nums1, int[] nums2) {
        dp = new int [nums1.Length,nums2.Length];
        for (int i = 0; i < dp.GetLength(0); i++)
        {
            for (int j = 0; j < dp.GetLength(1); j++)
            {
                dp[i, j] = -1;
            }
        }
        return MaxUncrossedLines(nums1, nums2, 0, 0);
    }

    private int MaxUncrossedLines(int[] nums1, int[] nums2, int i, int j) {
        
        if (i == nums1.Length || j == nums2.Length) return 0;

        if (dp[i,j] != -1) return dp[i,j];

        dp[i,j] = 0;

        if (nums1[i] == nums2[j]) dp[i,j] = 1 + MaxUncrossedLines(nums1, nums2, i+1, j+1);
        else dp[i,j] = Math.Max(MaxUncrossedLines(nums1, nums2, i+1, j), MaxUncrossedLines(nums1, nums2, i, j+1));
        return dp[i,j];
    }
}
