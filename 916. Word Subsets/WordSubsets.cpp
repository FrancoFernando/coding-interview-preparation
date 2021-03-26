class Solution {
public:
    vector<string> wordSubsets(vector<string>& A, vector<string>& B) {
        
        vector<string> ans;
        
        int signatureOfB[26] = {0};
        
        //build universal signature considering all words in B
        for (string const& s : B) {      
            
            int signature[26] = {0};
            
            for (char c : s) signature[c-'a']++;
            
            for (int i = 0; i < 26; ++i) {
                if (signature[i] > signatureOfB[i]) {
                    signatureOfB[i] = signature[i];
                }
            }
        }
        
        //check words in A against the signature
        for (string const& s : A) {  
            
            int signature[26] = {0};
            
            for (char c : s) signature[c-'a']++;
            
            bool isUniversal = true;
            
            for (int i = 0; i < 26; ++i) {
                if (signature[i] < signatureOfB[i]) {
                    isUniversal = false;
                    break;
                }
            }
            
            if (isUniversal) ans.push_back(s);
        }
        
        return ans;
    }
};