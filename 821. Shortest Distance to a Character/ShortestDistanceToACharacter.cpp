class Solution {
    
public:
    vector<int> shortestToChar(string s, char c) {
        
        vector<int> ans(s.size(),0);
        auto l = s.find_first_of(c);
        iota(ans.begin(), ans.begin()+l, 1);
        reverse(ans.begin(), ans.begin()+l);
        auto r = s.find_first_of(c, l+1);
        
        while (r != string::npos) {
            
            for (int i = l+1, j = r-1, cnt = 1; i <= j; ++i, --j, ++cnt) {
                ans[i] = cnt;
                ans[j] = cnt;
            }
            l = r;
            r = s.find_first_of(c, r+1);
        }
        
        iota(ans.begin()+l+1, ans.end(), 1);
        return ans;
    }
};