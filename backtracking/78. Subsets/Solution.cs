public class Solution {

    private IList<IList<int>> result;

    public IList<IList<int>> Subsets(int[] nums) {

        result = new List<IList<int>>();
        GenerateSubsets(nums, 0, new List<int>());
        return result;
    }

    private void GenerateSubsets(int[] nums, int index, IList<int> current) {

        if (index == nums.Length) { // is solution?
            result.Add(new List<int>(current));
            return;
        }

        current.Add(nums[index]);  // make move
        GenerateSubsets(nums, index+1, current);
        current.RemoveAt(current.Count - 1); // unmake move
        GenerateSubsets(nums, index+1, current);
        
    }
}
