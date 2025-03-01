public class Solution {
    public int MaxNumberOfApples(int[] weight) {
            
        Array.Sort(weight);
        int remainingCapacity = 5000;
        int count = 0;

        foreach (int appleWeight in weight) {
            if (appleWeight > remainingCapacity)
                break;
                
            remainingCapacity -= appleWeight;
            count++;
        }
        
        return count;
    }
}
