public class Solution {

    int getNextNumber(int n) {

        int nextNumber = 0;

            while (n > 0) {
                nextNumber += (int)Math.Pow(n % 10, 2);
                n /= 10;
            }
            
            return nextNumber;
    }

    public bool IsHappy(int n) {
        
        var seenNumbers = new HashSet<int>();

        while (n != 1 && !seenNumbers.Contains(n)) {
            seenNumbers.Add(n);
            n = getNextNumber(n);
        }

        return n == 1;
    }
}
