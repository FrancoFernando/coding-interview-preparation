class Solution {
public:
    int brokenCalc(int X, int Y) {
        
        if (X >= Y) return X-Y;
        
        int operations = 0;
        do {
            Y = (Y&1) ? Y+1 : Y/2;  
            operations++;
        } while(Y > X);
        return operations + X-Y;
    }
};