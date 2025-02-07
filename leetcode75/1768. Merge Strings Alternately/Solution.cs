public class Solution {
    public string MergeAlternately(string word1, string word2) {
        
        int length1 = word1.Length;
        int length2 = word2.Length;
        var result = new char[length1 + length2];
        int i = 0, j = 0, k = 0;

        while (i < length1 && j < length2) {
            result[k++] = word1[i++];
            result[k++] = word2[j++];
        }

        while(i < length1) result[k++] = word1[i++];
        while(j < length2) result[k++] = word2[j++];

        return new string(result);
    }
}
