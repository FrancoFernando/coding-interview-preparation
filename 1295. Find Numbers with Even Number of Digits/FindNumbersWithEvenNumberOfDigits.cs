public class Solution {
    public int FindNumbers(int[] nums) {
        
        int evenDigitNumbers = 0;
        foreach(int num in nums) {
            if(num.ToString().Length % 2 == 0) {
                evenDigitNumbers++;
            }
        }
        return evenDigitNumbers;
    }
}
