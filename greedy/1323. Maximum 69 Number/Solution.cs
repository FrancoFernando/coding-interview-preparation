public class Solution {
    public int Maximum69Number (int num) {
        char[] digits = num.ToString().ToCharArray();
        
        for (int i = 0; i < digits.Length; i++) {
            if (digits[i] == '6') {
                digits[i] = '9';
                return int.Parse(new string(digits));
            }
        }
        
        return num;
    }
}
