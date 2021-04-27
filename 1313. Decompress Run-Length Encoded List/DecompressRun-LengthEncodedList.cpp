class Solution {
public:
    vector<int> decompressRLElist(vector<int>& nums) {
        
        vector<int> list;
        
        for(int i = 0; i < nums.size(); i+=2) {
            //fill (2) void insert (iterator position, size_type n, const value_type& val);
            list.insert(list.end(), nums[i], nums[i+1]);
        }
        
        return list;
    }
};