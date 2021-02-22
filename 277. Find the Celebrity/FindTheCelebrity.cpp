/* The knows API is defined for you.
      bool knows(int a, int b); */

class Solution {
public:
    int findCelebrity(int n) {
        
        vector<bool> canBeCelebrity(n,true);
        for (int i = 0; i < n; ++i) {
            if (canBeCelebrity[i]) {
                for (int j = i+1; j < n; ++j) {
                    if (canBeCelebrity[j]) {
                        if (knows(i,j) == 0) canBeCelebrity[j] = false;
                        else canBeCelebrity[i] = false;
                    }
                }
            }
        }
        
        auto it = find(canBeCelebrity.begin(), canBeCelebrity.end(), true);
        if (it == canBeCelebrity.end()) return -1;
        int candidate = distance(canBeCelebrity.begin(),it);
        for (int i = 0; i < n; ++i) {
            if (i != candidate && (knows(i,candidate) == 0 || knows(candidate,i) == 1)) return -1;
        }
        return candidate;
    }
};