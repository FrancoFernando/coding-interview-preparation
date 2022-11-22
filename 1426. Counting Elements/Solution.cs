public class Solution {
    public int CountElements(int[] arr) {
        var numsInArr = new HashSet<int>(arr);
        int counter = 0;
        foreach (int num in arr) {
            if (numsInArr.Contains(num+1)) counter++;
        }
        return counter;
    }
}
