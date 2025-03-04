public class Solution {
    public int[] AnswerQueries(int[] nums, int[] queries) {
        
        var prefixSum = (int[])nums.Clone();
        Array.Sort(prefixSum);
        
        for (int i = 1; i < prefixSum.Length; i++) {
            prefixSum[i] += prefixSum[i - 1];
        }

        int[] result = new int[queries.Length];

        for (int i = 0; i < queries.Length; i++) {
            int index = Array.BinarySearch(prefixSum, queries[i]);
            result[i] = index < 0 ? ~index : index + 1;
        }

        return result;
    }
}
