public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        
        var magazineLettersFrequency = LettersFrequency(magazine);

        var ransomNoteLettersFrequency = LettersFrequency(ransomNote);

        for (int i = 0; i < 26; ++i) {
            if (ransomNoteLettersFrequency[i] > magazineLettersFrequency[i]) {
                return false;
            }
        }

        return true;
    }

    private int[] LettersFrequency(string s) {

        var frequencies = new int[26];

        foreach (char c in s) {
            frequencies[c-'a']++;
        }

        return frequencies;
    }
}
