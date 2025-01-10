public class Solution {
    public int[] SuccessfulPairs(int[] spells, int[] potions, long success) {
        
        int n = spells.Length, m = potions.Length;
        var result = new int[n];
        Array.Sort(potions);

        for (int i = 0; i < n; ++i) {
            //long minRequiredPotion = (success + spells[i] - 1) / spells[i]; //less readable way to calculate ceil division
            long minRequiredPotion = (long)Math.Ceiling((double)success / spells[i]);
            result[i] = m-BinarySearch(potions, minRequiredPotion);
        }
        return result;
    }

    int BinarySearch(int[] potions, long minRequiredPotion) {

        // initialize right to potions.Length allow to consider the case where no potion fits the requirement
        int left = 0, right = potions.Length;  

        while (left < right) {
            int mid = left + (right-left) / 2;
            if (potions[mid] >= minRequiredPotion) {
                right = mid;
            }
            else {
                left = mid+1;
            }
        }

        return right;
    }
}
