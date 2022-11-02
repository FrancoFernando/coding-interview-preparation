public class Solution {
    public int[] ReplaceElements(int[] arr) {
        
        int greatestValue = -1;
        
        for (int i = arr.Length-1; i >= 0; --i) {
            
            int newValue = greatestValue;
            greatestValue = Math.Max(greatestValue, arr[i]);
            arr[i] = newValue;
        }
        return arr;
    }
}
