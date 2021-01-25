class Solution {
public:
    bool kLengthApart(vector<int>& nums, int k) {
        
        int start = distance(nums.begin(), find(nums.begin(), nums.end(), 1));
        
        for (int i = start+1, count = 0; i < nums.size(); ++i) {
            
            if (nums[i] == 1 && count < k) {
                return false;   
            }
            else  {
                count = (nums[i] == 0) ? count+1 : 0;
            }
        }
        return true;
    }
};
