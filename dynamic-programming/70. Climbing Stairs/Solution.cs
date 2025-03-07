public class Solution {
    public int ClimbStairs(int n) {
        
        if (n <= 2) return n;
        
        int oneStepBefore = 2;
        int twoStepsBefore = 1;
        
        for (int i = 3; i <=n; i++) {
            int tmp = oneStepBefore;
            oneStepBefore += twoStepsBefore;
            twoStepsBefore = tmp;
        }
        return oneStepBefore;
    }
}
