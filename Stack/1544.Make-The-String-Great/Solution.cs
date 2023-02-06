public class Solution {
    public string MakeGood(string s) {
        
        var goodChars = new Stack<char>();
        foreach (char c in s) {
            char otherCase = Char.IsLower(c) ? Char.ToUpper(c) : Char.ToLower(c);
            if (goodChars.Count() > 0 && goodChars.Peek() == otherCase) {
                goodChars.Pop();
            }
            else {
                goodChars.Push(c);
            }
        }

        return String.Create(goodChars.Count(), goodChars, (g, s) => {
            int index = goodChars.Count()-1;
            foreach (char c in goodChars) g[index--] = c;
        });
    }
}
