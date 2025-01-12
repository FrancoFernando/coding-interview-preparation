public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        
        int left = 1, right = piles.Max();

        while (left < right) {
            int mid = left + (right - left) / 2;
            if (CanEatAll(piles, h, mid)) {
                right = mid;
            }
            else {
                left = mid+1;
            }
        }
        return left;
    }

    private bool CanEatAll(int[] piles, int h, int k) {
        int timeNeeded = 0;
        foreach (int pile in piles) {
            timeNeeded += (pile - 1) / k + 1;  // Equivalent to (int) Math.Ceiling(pile / (double)k)
            if (timeNeeded > h) return false;
        }
        return true;
    }
}

//n,n,n,n,n,n,y,y,y,y,y,y,y
