public class Solution {

    private IList<IList<int>> _result;
    private bool[] _used;
    private int[] _current;

    public IList<IList<int>> PermuteUnique(int[] nums) {

        _result = new List<IList<int>>();
        _current = new int[nums.Length];
        _used = new bool[nums.Length];
        GeneratePermutations(nums, 0);
        return _result;
    }

    private void GeneratePermutations(int[] nums, int index) {

        if (index == nums.Length) {
            _result.Add(new List<int>(_current));
            return;
        }

        // track values used at each recursion level to avoid using the same multiple times
        var usedValues = new HashSet<int>();

        for (int i = 0; i < nums.Length; i++) {
            if (!_used[i] && !usedValues.Contains(nums[i])) {
                _used[i] = true;
                _current[index] = nums[i];
                usedValues.Add(nums[i]);
                GeneratePermutations(nums, index + 1);
                _used[i] = false;
            }
        }
    }
}
