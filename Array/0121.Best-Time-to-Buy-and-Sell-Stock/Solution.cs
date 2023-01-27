public class Solution {
    public int MaxProfit(int[] prices) {
        
        int maxProfit = 0, minPrice = int.MaxValue;

        foreach(int price in prices) {
            maxProfit = Math.Max(maxProfit, price-minPrice);
            minPrice = Math.Min(price, minPrice);
        }
        return maxProfit;
    }
}
