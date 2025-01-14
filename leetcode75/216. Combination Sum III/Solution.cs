public class Solution {
    public IList<IList<int>> CombinationSum3(int k, int n) {
        List<IList<int>> result = new List<IList<int>>();
        Backtrack(k, n, 1, new List<int>(), result);
        return result;
    }

    public void Backtrack(int k, int remainingSum, int start, IList<int> current, List<IList<int>> result) {

        if (k == 0 && remainingSum == 0) {
            result.Add(new List<int>(current));
            return;
        }

        if (k <= 0 || remainingSum <= 0) {
            return;
        }

        for(int i = start; i <= 9 && i <= remainingSum; ++i) {
            current.Add(i);
            Backtrack(k-1, remainingSum-i, i+1, current, result);
            current.RemoveAt(current.Count - 1);
        }
    }
}
