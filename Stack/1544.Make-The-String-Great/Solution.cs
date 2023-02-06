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

// StringBuilder as stack
public class Solution {
    public string MakeGood(string s) {
        
        var sb = new StringBuilder();
        foreach (char c in s) {
            char otherCase = Char.IsLower(c) ? Char.ToUpper(c) : Char.ToLower(c);
            if (sb.Length > 0 && sb[sb.Length-1] == otherCase) sb.Remove(sb.Length-1,1);
            else sb.Append(c);
        }

        return sb.ToString();
    }
}
