public class Solution {

   private static readonly Dictionary<char, string> NumToLetters = new Dictionary<char, string> {
        {'2', "abc"},
        {'3', "def"},
        {'4', "ghi"},
        {'5', "jkl"},
        {'6', "mno"},
        {'7', "pqrs"},
        {'8', "tuv"},
        {'9', "wxyz"}
    };

    public IList<string> LetterCombinations(string digits) {

        if (string.IsNullOrEmpty(digits))
            return new List<string>();

        var result = new List<string>();
        Backtrack(digits, 0, new char[digits.Length], result);
        return result;
    }

     public void Backtrack(string digits, int index, char[] current, List<string> result) {

        if (index == digits.Length) {
            result.Add(new string(current));
            return;
        }
        
        foreach (char letter in NumToLetters[digits[index]]) {
            current[index] = letter;
            Backtrack(digits, index+1, current, result);
        }
     }
}
