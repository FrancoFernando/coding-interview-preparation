public class NumArray {

    private readonly int[] _prefixSum;

    public NumArray(int[] nums) {
        _prefixSum = new int[nums.Length];
        _prefixSum[0] = nums[0];
        for (int i = 1; i < nums.Length; i++) {
            _prefixSum[i] = _prefixSum[i-1] + nums[i];
        }
    }
    
    public int SumRange(int left, int right) {
        return (left > 0) ? _prefixSum[right] - _prefixSum[left-1] : _prefixSum[right];
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(left,right);
 */
