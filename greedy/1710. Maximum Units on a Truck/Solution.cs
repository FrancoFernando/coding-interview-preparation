public class Solution {
    public int MaximumUnits(int[][] boxTypes, int truckSize) {
        
        Array.Sort(boxTypes, (x,y) => y[1].CompareTo(x[1]));
        int totalUnits = 0;
        
        foreach (var box in boxTypes) {
            int boxCount = box[0];
            int unitsPerBox = box[1];
            
            int boxesToTake = Math.Min(boxCount, truckSize);
            totalUnits += boxesToTake * unitsPerBox;
            truckSize -= boxesToTake;
            
            if (truckSize == 0)
                break;
        }
        
        return totalUnits;
    }
}
