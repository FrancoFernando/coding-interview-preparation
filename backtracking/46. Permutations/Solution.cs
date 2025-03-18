public class Solution {

    private IList<IList<int>> _result;

    private bool[] _used;

    public IList<IList<int>> Permute(int[] nums) {

        _used = new bool[nums.Length];
        _result = new List<IList<int>>();
        GeneratePermutations(nums, 0, new int[nums.Length]);
        return _result;
    }

    private void GeneratePermutations(int[] nums, int index, int[] current) {

        if (index == nums.Length) {
            _result.Add(new List<int>(current));
            return;
        }

        for (int i = 0; i < nums.Length; ++i) {
            if (!_used[i]) {
                _used[i] = true;
                current[index] = nums[i];
                GeneratePermutations(nums, index+1, current);
                _used[i] = false;
            }
        }
    }
}
