public class Solution {
    public int[] NumsSameConsecDiff(int n, int k) {
        var result = new List<int>();
        GenerateNums(result, 1, n, k);
        return result.ToArray();
    }
    
    private void NumsSameConsecDiff(List<int> result, string current, int n, int k) {
        
        if (n == 0) {
            result.Add(current);
            return;
        }
        
        for (int next = current + k
    }
}
