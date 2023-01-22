public class Solution {
    public bool IsAnagram(string s, string t) {
        
        var signatureS = new int[26];
        var signatureT = new int[26];

        foreach (var c in s) signatureS[c-'a']++;
        foreach (var c in t) signatureT[c-'a']++;

        return signatureS.SequenceEqual(signatureT);
    }
}
