public class Solution {
    public string ReverseWords(string s) {
        
        var words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        return string.Join(' ',words.Reverse());
    }
}
