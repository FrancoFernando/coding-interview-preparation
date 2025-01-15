public class Solution {
    public int Tribonacci(int n) {
        if (n == 0) return 0;
        if (n <= 2) return 1;

        int a = 0, b = 1, c = 1;
        for (int i = 3; i <= n; i++) {
            int temp = a + b + c;
            a = b;
            b = c;
            c = temp;
        }

        return c;
    }
}
