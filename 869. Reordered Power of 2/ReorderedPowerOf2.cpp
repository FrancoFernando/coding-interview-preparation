class Solution {
    
    vector<int> buildSignature(int N) {
        
        vector<int> signature(10,0);
        while(N > 0) {
            signature[N%10]++;
            N /= 10;
        }
        return signature;
    }
    
public:
    bool reorderedPowerOf2(int N) {
        
        auto signatureOfN = buildSignature(N);
        
        for (int i = 0; i <= 31; ++i) {
            if (buildSignature(1 << i) == signatureOfN) return true;
        } 
        return false;
    }
};