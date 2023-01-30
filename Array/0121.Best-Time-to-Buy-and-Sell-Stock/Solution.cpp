class Solution {
public:
    int maxProfit(vector<int>& prices) {
        int minPrice = numeric_limits<int>::max(), maxGain = 0;
        for (int price : prices) {
            minPrice = min(minPrice, price);
            maxGain = max(maxGain, price-minPrice);
        }
        return maxGain;
    }
};
