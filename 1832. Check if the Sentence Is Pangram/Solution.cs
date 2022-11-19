public class Solution {
    public bool CheckIfPangram(string sentence) {
        
        var isCharUsed = new bool[26];
        
        foreach (char c in sentence) isCharUsed[c-'a'] = true;
        
        return isCharUsed.All(c => c);
     }
}
