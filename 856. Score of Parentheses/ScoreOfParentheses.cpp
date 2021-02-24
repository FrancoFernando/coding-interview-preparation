class Solution {
public:
    int scoreOfParentheses(string S) {
        
        vector<int> score(S.size(),0);
        int level = 0;
        for (char c : S) {
            if (c == '(') {
                level++;
            }
            else {
                level--;
                score[level] += max(2*score[level+1],1);
                score[level+1] = 0;
            }
        }
        return score[0];
    }
};