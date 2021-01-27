class Solution {
public:
    int concatenatedBinary(int n) {
        
        const int mod = 1000000007;
        //use long to preven overflow
        long ans = 0;
        for (int i = 1, size = 0; i <=n; ++i) {  
            //if i is a power of 2, increase the 
            //size of the current number to be 
            //shifted to the left
            if ((i & i-1) == 0) size++;
            ans = ((ans << size) | i) % mod;
        }
        return ans;
    }
};
