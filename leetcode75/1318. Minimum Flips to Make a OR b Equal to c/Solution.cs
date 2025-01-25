public class Solution {
    public int MinFlips(int a, int b, int c) {
        
        int flips = 0;

        while (a != 0 || b != 0 || c != 0) {
            int bitA = a & 1;
            int bitB = b & 1;
            int bitC = c & 1;

            if ((bitA | bitB) != bitC) {
                // c = 1 => a,b=0,0 one flip is enough
                // c = 0 => a,b=1,1 or 1,0 or 0,1 flips can be 1 or 2
                flips += bitC == 0 ? bitA + bitB : 1;
            }
            a >>= 1;
            b >>= 1;
            c >>= 1;
        }
        return flips;
    }
}
