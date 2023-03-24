public class Solution {
    public string RemoveStars(string s) {
        
        var sb = new StringBuilder();

        foreach (char c in s) {
            if (c != '*') sb.Append(c);
            else sb.Remove(sb.Length-1,1);
        }

        return sb.ToString();
    }
}
