class Solution {
public:
    vector<int> findErrorNums(vector<int>& nums) {
        
        bitset<10001> set;
        int duplicate = 0, missing = 0;
        int sum = 0, idealSum = 0, cnt = 0;
        
        for (int num : nums) {
            
            if (set.test(num) == 1) {
                duplicate = num;
            }
            
            set.set(num);
            sum += num;
            idealSum += (++cnt);
        }
        
        missing = duplicate + (idealSum-sum);
        
        return{duplicate, missing};
    }
};