public class Solution {
    public int ThirdMax(int[] nums) {
        
        SortedSet<int> maxNums = new SortedSet<int>();
        
        foreach (int num in nums) { 
            maxNums.Add(num);
            if (maxNums.Count > 3) maxNums.Remove(maxNums.Min);
        }
    
        return (maxNums.Count < 3) ? maxNums.Max : maxNums.Min;
    }
}
