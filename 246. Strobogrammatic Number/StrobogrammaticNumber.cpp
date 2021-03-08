class Solution {
    
    unordered_set<char> invalid{'2','3','4','5','7'};
    unordered_set<char> valid{'0','1','8'};
    unordered_map<char,char> match{{'0','0'},{'1','1'},{'6','9'},{'8','8'},{'9','6'}};
    
public:
    bool isStrobogrammatic(string num) {
        
        int i = 0, j = num.size()-1;
        while (i < j) {
            
            if (invalid.count(num[i]) > 0 || 
                invalid.count(num[j]) > 0 ||
                match[num[i]] != num[j]) return false;
            i++;
            j--;
        }
        return (i == j) ? valid.count(num[i]) : true;
    }
};