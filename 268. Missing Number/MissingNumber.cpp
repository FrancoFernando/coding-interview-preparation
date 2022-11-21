class Solution {
public:
    int missingNumber(vector<int>& nums) {

        int missingNumber = nums.size();
        for (int i = 0; i < nums.size(); ++i) {
            missingNumber ^= nums[i]^i;
        }
        return missingNumber;
    }
};
