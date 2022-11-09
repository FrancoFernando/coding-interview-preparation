public class Solution {
    public int HeightChecker(int[] heights) {
        
        const int maxHeight = 101;
        int differentHeights = 0;
        var heightsCounter = new int[maxHeight];

        foreach (int height in heights) heightsCounter[height]++;
        
        for (int i = 0, h = 0; i < maxHeight; ++i) {
            for (int j = 0; j < heightsCounter[i]; ++j) {
                if (heights[h++] != i) differentHeights++;
            }
        }

        return differentHeights;
    }
}
