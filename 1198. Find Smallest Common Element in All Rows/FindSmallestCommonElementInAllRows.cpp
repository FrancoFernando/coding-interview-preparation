class Solution {
public:
    int smallestCommonElement(vector<vector<int>>& mat) {
        
        unordered_map<int,int> numToFreq;
        for (int num : mat.front()) numToFreq[num] = 1;
        
        for (int i = 1; i < mat.size(); ++i) {
            for (int num : mat[i]) {
                if(numToFreq.count(num) > 0) {
                    numToFreq[num]++;
                }
            }
        }
        
        for (int num : mat.front()) {
            if (numToFreq[num] == mat.size()) return num;
        }
        
        return -1;
    }
};