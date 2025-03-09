public class Solution {
    public bool IsValid(string s) {
            
        if (s.Length % 2 != 0)
            return false;

        var bracketsMap = new Dictionary<char, char> {
            {')', '('},
            {']', '['},
            {'}', '{'}
        };
        
        var stack = new Stack<char>();

        foreach (char c in s) {
            if (bracketsMap.ContainsKey(c)) {
                // Closing bracket
                if (stack.Count == 0 || stack.Pop() != bracketsMap[c])
                    return false;
            } else {
                // Opening bracket
                stack.Push(c);
            }
        }
        
        return stack.Count == 0;
    }
}
