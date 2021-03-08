class Solution {
    
    bool isPalindrome(string const& s) {
        
        int i = 0, j = s.size()-1;
        while (i < j) {
            if (s[i++] != s[j--]) return false;
        }
        return true;
    }
    
public:
    int removePalindromeSub(string s) {
        
        if (s.empty()) return 0;
        else return isPalindrome(s) ? 1 : 2;
    }
};