class Solution {
public:
    int distributeCandies(vector<int>& candies) {
        
        unordered_set<int> types;
        for (int candy : candies) {
            types.insert(candy);
        }
        return min(candies.size()/2, types.size());
    }
};