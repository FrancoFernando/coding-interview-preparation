class Solution {
public:
    int findUnsortedSubarray(vector<int>& nums) {
        
        int maxIndex = 0;
        int start = -1, end = -1;
        
        for (int i = 0; i < nums.size(); ++i) {
            
            if (nums[i] < nums[maxIndex]) {
               int j = (start < 0) ? maxIndex : start;
               while (j > 0 && nums[i] < nums[j-1]) j--;
               start = j; 
               end = i;
            }
            else if (nums[i] > nums[maxIndex]){
                maxIndex = i;
            }
        }
        
        return (start < 0) ? 0 : end-start+1;
    }
};