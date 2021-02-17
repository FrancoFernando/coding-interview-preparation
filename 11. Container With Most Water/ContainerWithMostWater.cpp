class Solution {
public:
    int maxArea(vector<int>& height) {
        
        int maxWater = 0;
        
        for (int l = 0, r = height.size()-1; l < r;){
            int minHeight = min(height[l], height[r]);
            int width = r-l;
            maxWater = max(maxWater, minHeight*width);
            (height[l] <= height[r]) ? l++ : r--;
        }
        return maxWater;
    }
};