class Solution {
    
    vector<vector<int>> dp;
     
    int maxProfit(vector<int>& prices, int fee, int day, bool hasStock) {
        
        if (day >= prices.size()) return 0;
        
        if (dp[static_cast<int>(hasStock)][day] < 0) {
            
            if (hasStock) {
                dp[static_cast<int>(hasStock)][day] =
                    max(prices[day] + maxProfit(prices, fee, day+1, false), maxProfit(prices, fee, day+1, true)); 
            }
            else {
                dp[static_cast<int>(hasStock)][day] =
                    max(maxProfit(prices, fee, day+1, true)-prices[day]-fee, maxProfit(prices, fee, day+1, false)); 
            }
        }
        
        return dp[static_cast<int>(hasStock)][day];
    }
    
public:
    int maxProfit(vector<int>& prices, int fee) {
        dp.resize(2, vector<int>(prices.size(), -1));
        return maxProfit(prices, fee, 0, false);
    }
};