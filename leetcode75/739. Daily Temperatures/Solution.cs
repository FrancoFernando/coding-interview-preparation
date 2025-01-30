public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        
        int n = temperatures.Length;
        var s = new Stack<int>();
        var result = new int[n];

        for(int i = n-1; i >= 0; i--) {
            
            while(s.Count > 0 && temperatures[s.Peek()] <= temperatures[i]) {
                s.Pop();
            }

            if (s.Count > 0) {
                result[i] = s.Peek() - i; 
            } 
            s.Push(i);
        }
        return result;
    }
}
