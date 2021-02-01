class Solution {
public:
    int hammingWeight(uint32_t n) {
        
        int w = 0;
        while (n > 0) {
            if (n & 1) ++w;
            n >>= 1;
        }
        return w;
    }
};