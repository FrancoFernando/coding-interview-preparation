public class Solution {
    public string RemoveDuplicates(string s) {
        
        Stack<char> chars = new Stack<char>();
        foreach (var c in s) {
            if (chars.Count == 0 || chars.Peek() != c) chars.Push(c);
            else chars.Pop();
        }

        string answer = string.Create(chars.Count(), chars, (a,s) => {
            int index = chars.Count()-1;
            foreach(var c in s) a[index--] = c;
        });
        return answer;
    }
}
