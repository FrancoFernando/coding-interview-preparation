public class Solution {
    public bool CheckInclusion(string s1, string s2) {

        if (s1.Length > s2.Length) return false;
        
        var s1Frequencies = new int[26];
        var s2Frequencies = new int[26];

        for (int i = 0; i < s1.Length; ++i) {
            s1Frequencies[s1[i]-'a']++;
            s2Frequencies[s2[i]-'a']++;
        }

        for (int i = s1.Length; i < s2.Length; ++i) {
            if (s1Frequencies.SequenceEqual(s2Frequencies)) return true;
            s2Frequencies[s2[i]-'a']++;
            s2Frequencies[s2[i-s1.Length]-'a']--;
        }
        return s1Frequencies.SequenceEqual(s2Frequencies);
    }
}
