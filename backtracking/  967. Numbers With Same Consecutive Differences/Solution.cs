public class Solution {
    public int[] NumsSameConsecDiff(int n, int k) {
        var result = new List<int>();
        for (int digit = 1; digit <= 9; digit++) {
            GenerateNums(result, digit, n-1, k);
        }
        return result.ToArray();
    }
    
    private void GenerateNums(List<int> result, int current, int remainingDigits, int k) {
        
        if (remainingDigits == 0) {
            result.Add(current);
            return;
        }
        
        int lastDigit = current % 10;
        int nextDigitUp = lastDigit + k;
        if (nextDigitUp < 10) {
            int num = current * 10 + nextDigitUp;
            GenerateNums(result, num, remainingDigits-1, k);
        }

        int nextDigitDown = lastDigit - k;
        if (nextDigitDown >=0 && k != 0) {
            int num = current * 10 + nextDigitDown;
            GenerateNums(result, num, remainingDigits-1, k);
        }
    }
}
