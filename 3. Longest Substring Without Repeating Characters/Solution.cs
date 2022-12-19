public class Solution {
    public int LengthOfLongestSubstring(string s) {

        var charsInWindow = new HashSet<char>();
        int maxLength = 0;

        for (int left = 0, right = 0; right < s.Length; ++right) {
            
            if (!charsInWindow.Add(s[right])) {
                
                while (charsInWindow.Contains(s[right])) {
                    charsInWindow.Remove(s[left++]);
                }
                charsInWindow.Add(s[right]);
            }

            maxLength = Math.Max(maxLength, right-left+1);
        }

        return maxLength;
    }
}
