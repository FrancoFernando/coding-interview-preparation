class Solution {
    
    int countSlices (int len) {
        
        int slices = 0;
        for (int j = 1; j <len; ++j) {
            slices += (len-j);
        }
        return slices;
    }
    
public:
    int numberOfArithmeticSlices(vector<int>& A) {
        
        if(A.size() < 3) return 0;
        
        int len = 1, slices = 0;
        
        for (int i = 2, diff = A[1]-A[0]; i < A.size(); ++i) {
            if ((A[i]-A[i-1]) == diff) {
                len++;    
            }
            else {
                slices += countSlices(len);
                len = 1;
                diff = A[i]-A[i-1];
            }
        }
        
        slices += countSlices(len);
        
        return slices;
    }
};