class Solution {
    
    using pii = pair<int,int>;
    
public:
    vector<int> advantageCount(vector<int>& A, vector<int>& B) {
        
        const int size = A.size();
        
        vector<pii> P(size);
        for(int i = 0; i < size; ++i) P[i] = make_pair(B[i],i);
        
        sort(A.begin(), A.end());
        sort(P.begin(), P.end());
        
        vector<int> perm(size);
        
        for (int i = 0, j = 0, k = size-1; i < size; ++i) {
            
            if (A[i] <= P[j].first) perm[P[k--].second] = A[i];
            else perm[P[j++].second] = A[i];
        }
          
        return perm;
    }
};