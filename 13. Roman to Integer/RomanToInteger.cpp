class Solution {
public:
    int romanToInt(string s) {
        
        unordered_map<char,int> symbol2val{
            {'I',1},
            {'V',5},
            {'X',10},
            {'L',50},
            {'C',100},
            {'D',500},
            {'M',1000}
        };
        
        int num = symbol2val[s.back()];
        
        for (int i = 0; i < (s.size()-1); ++i) {
            int val = symbol2val[s[i]];
            if ((s[i] == 'I' && (s[i+1] == 'V' || s[i+1] == 'X')) ||
                (s[i] == 'X' && (s[i+1] == 'L' || s[i+1] == 'C')) ||
                (s[i] == 'C' && (s[i+1] == 'D' || s[i+1] == 'M'))){
                val = -val;
            }
            num += val;
        }
        return num;
    }
};