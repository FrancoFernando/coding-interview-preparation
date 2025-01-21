// Top down
public class Solution {

    private Dictionary<(int,bool), int> cache;

    public int MaxProfit(int[] prices, int fee) {
        cache = new Dictionary<(int,bool), int>();
        return MaxProfit(prices, fee, 0, true);
    }

    private int MaxProfit(int[] prices, int fee, int day, bool canBuy) {

        if (day == prices.Length) 
            return 0;

        if (cache.ContainsKey((day,canBuy)))
            return cache[(day,canBuy)];
        
        int result;
        if (canBuy) {
            int skipDay = MaxProfit(prices, fee, day+1, true);
            int buy = MaxProfit(prices, fee, day+1, false) - prices[day];
            result = Math.Max(skipDay, buy);
        }
        else {
            int skipDay = MaxProfit(prices, fee, day+1, false);
            int sell = MaxProfit(prices, fee, day+1, true) + prices[day] - fee;
            result = Math.Max(skipDay, sell);
        }
        cache[(day,canBuy)] = result;
        return result;
    }
}
