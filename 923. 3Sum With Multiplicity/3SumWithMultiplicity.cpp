class Solution {
public:
    int threeSumMulti(vector<int>& arr, int target) {
        
        long ans = 0;
        sort(arr.begin(), arr.end());
        
        for (int i = 0; i < arr.size(); ++i) {
            
            //Fix a number (arr[i]) to reduce the problem to two sum
            int twoSumTarget = target - arr[i];
            
            int j = i+1, k = arr.size()-1; 
            
            while (j < k) {
                
                int val1 = arr[j], val2 = arr[k];
                
                if (val1+val2 < twoSumTarget) {
                    ++j;
                }
                else if (val1+val2 > twoSumTarget) {
                    --k;
                }
                else {
                    //if the two values are equal, 
                    //the first can be paired with all after the first one
                    //the second can be paired with all after the second one
                    //and so on...
                    if (val1 == val2) {
                        while (j < k) {
                            ans += k-j;
                            ++j;
                        }
                    }
                    else {
                        //if the two values are different, the number of pairs
                        //corresponds to the cross product of their occurrences
                        int nVal1 = 1, nVal2 = 1;
                        while (arr[++j] == val1) nVal1++;
                        while (arr[--k] == val2) nVal2++;
                        ans += nVal1*nVal2;
                    }
                }
            }
        }
        return ans % 1000000007;
    }
};