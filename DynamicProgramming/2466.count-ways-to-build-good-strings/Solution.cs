public class Solution {

    private int lowerBound;
    private int upperBound;
    private int numZeros;
    private int numOnes;
    private const int mod = 1_000_000_007;
    private int[] dp;

    public int CountGoodStrings(int low, int high, int zero, int one) {
        
        lowerBound = low;
        upperBound = high;
        numZeros = zero;
        numOnes = one;
        dp = new int[upperBound+1];
        Array.Fill(dp, -1);
        return CountGoodStrings(0);
    }

    private int CountGoodStrings(int len) {

        if (len > upperBound) return 0;
        if (dp[len] != -1) return dp[len];
        int goodStrings = (len < lowerBound) ? 0 : 1;
        goodStrings += (CountGoodStrings(len+numZeros) % mod);
        goodStrings += (CountGoodStrings(len+numOnes) % mod);
        dp[len] = (goodStrings % mod);
        return dp[len];
    }
}

// iterative

public class Solution {

    private const int mod = 1_000_000_007;
    private int[] dp;

    public int CountGoodStrings(int low, int high, int zero, int one) {
        
        dp = new int[high+1];
        dp[0] = 1;
        for (int i = 0; i < dp.Length; ++i) {
            if (dp[i] > 0) {
                if (i+zero < dp.Length) {
                    dp[i+zero] += (dp[i] % mod);
                    dp[i+zero] %= mod;
                } 
                if (i+one < dp.Length) {
                    dp[i+one] += (dp[i] % mod);
                    dp[i+one] %= mod;
                } 
            }
        }
        
        int ans = 0;
        for (int i = low; i < dp.Length; ++i) {
            ans += dp[i];
            ans %= mod;
        } 
        return ans;
    }
}
