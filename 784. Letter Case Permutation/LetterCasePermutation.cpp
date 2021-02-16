class Solution {
    
    vector<string> ans;
    
    void letterCasePermutation(string& S, int pos) {
        
        if (pos == S.size()) {
            ans.push_back(S);
        }
        else {
            if (isalpha(S[pos])) {
                S[pos] = (islower(S[pos]) != 0) ? toupper(S[pos]) : tolower(S[pos]);
                letterCasePermutation(S, pos+1);
                S[pos] = (islower(S[pos]) != 0) ? toupper(S[pos]) : tolower(S[pos]);
            }              
            letterCasePermutation(S, pos+1);
        }       
    }
    
public:
    vector<string> letterCasePermutation(string S) {
        
        letterCasePermutation(S,0);
        return ans;
        
    }
};