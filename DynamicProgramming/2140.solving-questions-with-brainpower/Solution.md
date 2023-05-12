public class Solution {

    long[] dp;

    public long MostPoints(int[][] questions) {
        dp = new long[questions.Length];
        Array.Fill(dp,-1);
        return MostPoints(questions, 0);
    }

    private long MostPoints(int[][] questions, int pos) {
        
        if (pos >= questions.Length) return 0;
        if (dp[pos] != -1) return dp[pos];

        long withQuestion = questions[pos][0] + MostPoints(questions, pos+questions[pos][1]+1);
        long withoutQuestion = MostPoints(questions, pos+1);
        dp[pos] = Math.Max(withQuestion, withoutQuestion);
        return dp[pos];
    }
}
