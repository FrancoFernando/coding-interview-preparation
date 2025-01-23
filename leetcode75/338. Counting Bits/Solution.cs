// O(NlgN) solutiion
public class Solution {
    public int[] CountBits(int n) {
        
        var result = new int[n+1]; 

        for (int i = 0; i <= n; ++i) {
            result[i] = countOnes(i);
        }

        return result;
    }

    private int countOnes(int n) {
        int ones = 0;

        while (n > 0) {
            ones += n % 2;
            n /= 2;
        }

        return ones;
    }
}
