public class Solution {
    public int FindMinArrowShots(int[][] points) {
        
        Array.Sort(points, (x, y) => x[1].CompareTo(y[1]));

        int arrows = 1;
        long end = points[0][1];

        for (int i = 1; i < points.Length; i++) {
            if (points[i][0] > end) {
                arrows++;
                end = points[i][1];
            }
        }

        return arrows;
    }
}
