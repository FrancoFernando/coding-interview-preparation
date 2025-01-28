public class Solution {

    public int EraseOverlapIntervals(int[][] intervals) {
        
        Array.Sort(intervals, (x,y) => x[1].CompareTo(y[1]));

        int count = 0;
        var endOfInterval = Int32.MinValue;
        foreach (var interval in intervals) {
            if (interval[0] >= endOfInterval) {
                endOfInterval = interval[1];
            }
            else {
                count += 1;
            }
        }
        return count;
    }
}
