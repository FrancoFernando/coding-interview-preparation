class Solution {
    
    template <typename Iterator>
    string removeUnmatched (Iterator iter, Iterator end, char c1, char c2) {
        
        string ans;
        int unmatched = 0;
        
        for (; iter != end; ++iter) {
            char c = *iter;
            if (c == c1) {
                ans.push_back(c);
                unmatched++;
            }
            else if (c == c2) {
                if (unmatched > 0) {
                    ans.push_back(c);
                    unmatched--;
                }     
            }
            else {
                ans.push_back(c);
            }
        }
        return ans;
    }
    
public:
    string minRemoveToMakeValid(string s) {
        //removing first unmatched ( and then ) avoid reverse
        s = removeUnmatched(s.rbegin(), s.rend(), ')', '(');
        return removeUnmatched(s.rbegin(), s.rend(), '(', ')');
    }
};