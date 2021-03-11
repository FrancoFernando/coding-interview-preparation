class Solution {
   
    vector<int> dp;
   
    int coinChangeHelper(vector<int>& coins, int amount) {
       
        //change is possible
        if (amount == 0) return 0;
        
        //change is not possible
        if (amount < 0) return -1;
       
        if (dp[amount] == INT_MAX) {      
            
            for (int coin : coins) {
                int nCoins = 1 + coinChangeHelper(coins, amount-coin);
                if (nCoins > 0 && nCoins < dp[amount]) dp[amount] = nCoins;                
            }
            if (dp[amount] == INT_MAX) dp[amount] = -1;
        }
       
        return dp[amount];
    }
   
public:
    int coinChange(vector<int>& coins, int amount) {
        dp.resize(amount+1, INT_MAX);
        return coinChangeHelper(coins, amount);
    }
};