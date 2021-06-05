class Solution {
    
    using pii = pair<int,int>;
    
public:
    int maxPerformance(int n, vector<int>& speed, vector<int>& efficiency, int k) {
        
        const int mod = 1000000007;
        vector<pii> engineersData(n);
        for (int i = 0; i < n; ++i) 
        {
            engineersData[i].first = efficiency[i];
            engineersData[i].second = speed[i];
        }
        // by default std::sort sort based on pair::first and then pair::second
        // reverse iterator to sort in non increasing order
        sort(engineersData.rbegin(), engineersData.rend());
        
        // consider the current engineer as the one having minimum efficiency
        // and find the remaining k-1 in the engineers with index j < i
        // to maximize performances the remaining must be the one with  
        // maximum speed -> use a pq (min heap) to keep track of the k-1 
        // maximum speed among the speed of the previous engineers
        
        priority_queue<int, vector<int>, greater<int>> pq;
        long max_performance = 0, cumulative_speed = 0;
        for (int i = 0; i < n; ++i) 
        {
            int min_efficiency = engineersData[i].first;
            int speed = engineersData[i].second;
            
            cumulative_speed += speed;
            pq.push(speed);
            
            if (pq.size() > k) 
            {
                cumulative_speed -= pq.top(); 
                pq.pop();
            }
            
            max_performance = max(max_performance, cumulative_speed*min_efficiency);
        }
        return max_performance % mod;
    }
};