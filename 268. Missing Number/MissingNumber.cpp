class Solution {
public:
    int missingNumber(vector<int>& nums) {
        
        int idealXor = nums.size(), realXor = 0;
        
        for (int i = 0; i < nums.size(); ++i) {
            idealXor ^= i;
            realXor ^= nums[i];
        }
        
        return realXor ^ idealXor;
    }
};