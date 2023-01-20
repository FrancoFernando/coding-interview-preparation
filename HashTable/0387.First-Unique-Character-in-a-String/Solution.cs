public class Solution {
    public int FirstUniqChar(string s) {
        
        var charToFirstOccurrence = new Dictionary<char,int>();

        for (int i = 0; i < s.Length; ++i) {
            charToFirstOccurrence[s[i]] = charToFirstOccurrence.ContainsKey(s[i]) ? s.Length : i;
        }

        int ans = charToFirstOccurrence.Values.Min();
        return ans == s.Length ? -1 : ans;
    }
}
