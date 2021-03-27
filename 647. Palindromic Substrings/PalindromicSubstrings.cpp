class Solution {
    
    vector<vector<bool>> isCounted;
    
    int countSubstrings(string s, int i, int j) {
        
        if (i < 0 || j >= s.size() || isCounted[i][j] || s[i] != s[j]) return 0;
        isCounted[i][j] = true;
        return 1 + countSubstrings(s, i-1, j+1);
    }
    
public:
    int countSubstrings(string s) {
        
        int cnt = 0;
        isCounted.resize(s.size(), vector<bool>(s.size(), false));
        
        for (int i = 0; i < s.size(); ++i) {
            cnt +=  countSubstrings(s,i,i);
            cnt +=  countSubstrings(s,i,i+1);
            cnt +=  countSubstrings(s,i-1,i);
        }
        
        return cnt;
    }
};