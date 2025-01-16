public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        int previousCost = 0, currentCost = 0;

        for (int i = 2; i <= cost.Length; i++) {
            int nextCost = Math.Min(cost[i - 1] + currentCost, cost[i - 2] + previousCost);
            previousCost = currentCost;
            currentCost = nextCost;
        }

        return currentCost;
    }
}
