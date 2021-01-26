class Solution {
    using tiii = tuple<int,int,int>;
public:
    int minimumEffortPath(vector<vector<int>>& heights) {
        
        const int rows = heights.size(), cols = heights[0].size();
        
        //minimum effort required to reach each cell from 0,0
        vector<vector<int>> distance(rows, vector<int>(cols, INT_MAX));
        
        //min_heap
        auto cmp = [](auto const& lhs, auto const& rhs){
            return get<2>(lhs) > get<2>(rhs);   
        };
        priority_queue<tiii,vector<tiii>, decltype(cmp)> pq(cmp);
        pq.emplace(0,0,0);
        //also the distance of the starting cell shall be updated
        //otherwise in case of matrix of one element result is incorrect
        distance[0][0] = 0;  
        
        while (!pq.empty()) {
            int x, y, d;
            tie(x,y,d) = pq.top();
            pq.pop();
            
            if (x == rows-1 && y == cols-1) return distance[x][y];
            
            //other occurrences of the x,y cell with greater
            //distance shall be ignored
            if (d <= distance[x][y]) {
                //offset to compute the coordinates of the cells around the current one
                const vector<vector<int>> offsets{{1,0},{-1,0},{0,1},{0,-1}};
                for (auto const& offset : offsets) {
                    int nextX = x+offset[0];
                    int nextY = y+offset[1];
                    //the next cell shall be in the matrix
                    if (nextX >= 0 && nextX < rows && 
                        nextY >= 0 && nextY < cols) {
                        //effort to reach the next cell from the current one
                        int effort = abs(heights[x][y]-heights[nextX][nextY]);
                        //the max effort to reach the next cell from 0,0
                        //is the max between effort and the  
                        //max effort to reach the current cell from 0,0
                        int maxEffort = max(effort, distance[x][y]);
                        //consider the next cell only if can be reached with 
                        //less effort than the current minimum one
                        if (maxEffort < distance[nextX][nextY]) {
                            distance[nextX][nextY] = maxEffort;
                            pq.emplace(nextX, nextY, maxEffort);    
                        }             
                    } 
                }
            }
        }
        //never reach this point
        return -1;
    }
};