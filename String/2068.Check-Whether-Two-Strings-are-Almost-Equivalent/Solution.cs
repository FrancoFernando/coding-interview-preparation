public class Solution {
    public bool CheckAlmostEquivalent(string word1, string word2) {

        const int alphabetSize = 26, maxFrequencyDifference = 3;
        
        var frequency1 = new int[alphabetSize];
        foreach (char c in word1) frequency1[c-'a']++;

        var frequency2 = new int[alphabetSize];
        foreach (char c in word2) frequency2[c-'a']++;

        for (int i = 0; i < alphabetSize; ++i) {
            if (Math.Abs(frequency1[i]-frequency2[i]) > maxFrequencyDifference) return false;
        }
        return true;
    }
}
