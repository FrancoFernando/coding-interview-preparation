public class Solution {
    private IList<IList<int>> _result;
    private IList<int> _current;
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {
        _current = new List<int>();
        _result = new List<IList<int>>();
        Array.Sort(candidates);
        Backtrack(candidates, 0, target);
        return _result;
    }

    private void Backtrack(int[] candidates, int startIndex, int remaining) {
        
        if (remaining == 0) {
            _result.Add(new List<int>(_current));
            return;
        }

        for (int i = startIndex; i < candidates.Length; i++) {
            int num = candidates[i];
            if (num > remaining) break;
            _current.Add(num);
            Backtrack(candidates, i, remaining - num);
            _current.RemoveAt(_current.Count - 1);
        }
    }
}
