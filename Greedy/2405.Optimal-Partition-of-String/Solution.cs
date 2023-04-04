public class Solution {
    public int PartitionString(string s) {

        int numberOfPartitions = 1;
        var isCharInSubstring = new bool[26];
        
        foreach (char c in s) {
            
            if (isCharInSubstring[c-'a']) {
                numberOfPartitions++; 
                Array.Fill(isCharInSubstring, false);
            }

            isCharInSubstring[c-'a'] = true;
        }

        return numberOfPartitions;
    }
}
