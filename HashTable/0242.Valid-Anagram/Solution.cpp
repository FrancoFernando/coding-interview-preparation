class Solution {
public:
    bool isAnagram(string s, string t) {
        
        const int alphabetSize = 26;
        
        if (s.size() != t.size()) return false;
        
        int freqS[alphabetSize] = {0}, freqT[alphabetSize]= {0};
        for (int i = 0; i < s.size(); ++i) {
            freqS[s[i]-'a']++;
            freqT[t[i]-'a']++;
        }
        
        for (int i = 0; i < alphabetSize; ++i) {
            if (freqS[i] != freqT[i]) return false;
        }
        
        return true;
    }
};
