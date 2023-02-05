public class Solution {
    public bool IsValid(string s) {
        
        var CloseToOpen = new Dictionary<char, char>(){
            [')'] = '(',
            [']'] = '[',
            ['}'] = '{'
        };

        var parentheses = new Stack<char>();
        foreach (char c in s) {
            
            if (CloseToOpen.TryGetValue(c, out char open)) {
                if (parentheses.Count() > 0 && parentheses.Peek() == open) parentheses.Pop();
                else return false;
            }
            else {
                parentheses.Push(c);
            }
        }
        return parentheses.Count() == 0;
    }
}
