public class Solution {
    public bool IncreasingTriplet(int[] nums) {
        
        var first = int.MaxValue;
        var second = int.MaxValue;

        foreach (int num in nums) 
        {
            if (num <= first)
            {
                first = num;
            }
            else if (num <= second)
            {
                second = num;
            }
            else
            {
                return true;
            }
        }
        return false;
    }
}
