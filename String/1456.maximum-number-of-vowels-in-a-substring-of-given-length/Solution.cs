public class Solution {
    public int MaxVowels(string s, int k) {
        
        int vowelsInSubstring = 0;
        for (int i = 0; i < k; ++i) {
            if (IsVowel(s[i])) vowelsInSubstring++;
        }

        int answer = vowelsInSubstring;

        for (int start = 0, end = k; end < s.Length; ++start, ++end) {
            if (IsVowel(s[start])) vowelsInSubstring--;
            if (IsVowel(s[end])) vowelsInSubstring++;
            if (vowelsInSubstring > answer) answer = vowelsInSubstring;
        }

        return answer;
    }

    private bool IsVowel(char c) {
        char[] vowels = new char[]{ 'a','e','i','o','u'};
        return vowels.Contains(c);
    }
}
