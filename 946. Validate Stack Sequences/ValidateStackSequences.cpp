class Solution {
public:
    bool validateStackSequences(vector<int>& pushed, vector<int>& popped) {
        
        stack<int> s;
        
        int i = 0, j = 0;
        
        //check pushed is enough: can't pop all nums before pushing them
        while (i < pushed.size()) {            
            if (!s.empty() && s.top() == popped[j]) {
                s.pop();
                j++;
            }
            else {
                s.push(pushed[i]);
                i++;
            }
        }
        
        //check pushed is enough: can't pop all item if stack is not empty
        while (!s.empty() && s.top() == popped[j++]) s.pop();
                
        return s.empty();
    }
};