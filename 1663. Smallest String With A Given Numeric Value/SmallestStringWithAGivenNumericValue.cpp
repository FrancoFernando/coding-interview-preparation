class Solution {
public:
    string getSmallestString(int n, int k) {
        
        int maxK = n*26;
        string s;
        
        while (k < maxK) {
            s.push_back('a');
            n--;
            k--;
            maxK-=26;
        }
        
        if (!s.empty()) s.back() = 'a' + (k%26);
        
        while (n > 0) {
            s.push_back('z');
            n--;
        }
        
        return s;
    }
};