class Solution {
    
    using pii = pair<int,int>;
    
public:
    int minimumDeviation(vector<int>& nums) {
        
        priority_queue<pii, vector<pii>, greater<pii>> pq;
        int minVal = 0, maxVal = 0;
        
        for (int num : nums) {
            if (num & 1) {
                pq.emplace(num, num*2);
                maxVal = max(maxVal, num);
            }
            else {
                int minVal = num;
                while (!(minVal&1)) minVal /= 2;
                pq.emplace(minVal, num);
                maxVal = max(maxVal, minVal);
            }     
        }
        
        int ans = INT_MAX;
        
        //stop when one rang has been explored
        while (pq.size() == nums.size()) {
            int val, maxValRange;
            tie(val,maxValRange) = pq.top();
            pq.pop();
            ans = min(ans, maxVal - val);
            if (val < maxValRange) {
                pq.emplace(val*2, maxValRange);
                maxVal = max(maxVal, val*2);
            }
        }
        return ans;
    }
};
