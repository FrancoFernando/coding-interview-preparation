class Solution {
public:
    bool hasAllCodes(string s, int k) {
        
        int value = stoi(s.substr(0,k).c_str(),nullptr,2);
        set<int> codes{value};
        
        const int resetMask = ~(1<<k), nCodes = pow(2,k);
        
        for (int i = k; i < s.size() && codes.size() < nCodes; ++i) {
            //make room for the new bit
            value <<= 1;   
            //reset the bit moved outside the window
            value &= resetMask;
            //set the new bit if needed
            if (s[i] == '1') value |= 1;
            //add the code
            if (codes.count(value) == 0) codes.insert(value);
        }
        
        return codes.size() == nCodes;
    }
};