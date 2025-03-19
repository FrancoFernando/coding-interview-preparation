public class Solution {

    private IList<string> _result; 

    public IList<string> GenerateParenthesis(int n) {
        
        _result = new List<string>();
        BackTrack (n, 0, 0, new char[n * 2], 0);
        return _result;
    }

    public void BackTrack (int n, int openCount, int closeCount, char[] current, int index) {

        if (index == current.Length) {
            _result.Add(new string(current));
            return;
        }

        if (openCount < n) {
            current[index] = '(';
            BackTrack (n, openCount+1, closeCount, current, index+1);
        }

        if (closeCount < openCount) {
            current[index] = ')';
            BackTrack (n, openCount, closeCount+1, current, index+1);
        }
    }
}
