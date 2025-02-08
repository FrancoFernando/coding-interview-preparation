public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        
        int length = flowerbed.Length;

        for (int i = 0; i < length && n > 0; ++i) {

            if (flowerbed[i] == 1)
                continue;
            
            bool emptyLeftPlot = i-1 < 0 || flowerbed[i-1] == 0;
            bool emptyRightPlot = i+1 >= length || flowerbed[i+1] == 0;

            if (emptyLeftPlot && emptyRightPlot) {
                n = n-1;
                flowerbed[i] = 1;
            }
        }
        return n == 0;
    }
}
