public class Solution {
    
    private IList<IList<int>> _result;
    private IList<int> _current;
    
    public IList<IList<int>> CombinationSum3(int k, int n) {
        _current = new List<int>();
        _result = new List<IList<int>>();
        Backtrack(k, n, 1);
        return _result;
    }

    public void Backtrack(int k, int remainingSum, int start) {

        //base case
        if (k == 0 && remainingSum == 0) {
            _result.Add(new List<int>(_current));
            return;
        }
        
        //pruning
        if (k <= 0 || remainingSum <= 0) {
            return;
        }

        for(int i = start; i <= 9 && i <= remainingSum; ++i) {
            _current.Add(i);
            Backtrack(k-1, remainingSum-i, i+1);
            _current.RemoveAt(_current.Count - 1);
        }
    }
}
