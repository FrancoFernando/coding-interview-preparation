class Solution {
    
    int manhattanDistance (vector<int>& p1, vector<int>& p2) {
        return abs(p1[0]-p2[0]) + abs(p1[1]-p2[1]);
    }
    
    //the first nut to pick up is not the closest one, but the one maximizing
    //the difference between the path  tree->nut->tree and the path squirrel->nut->tree
    int getFirstNut (vector<int>& squirrel, vector<vector<int>>& nuts, vector<int>& tree) {
        
        int distance = INT_MIN, index = -1;
        for (int i = 0; i < nuts.size(); ++i) {
            int distSquirrel = manhattanDistance(squirrel, nuts[i]);
            int distTree = manhattanDistance(tree, nuts[i]);
            int d = (distTree*2) - (distSquirrel+distTree);
            
            if (d > distance) {
                distance = d;
                index = i;
            }
        }
        return index;
    }
    
public:
    int minDistance(int height, int width, vector<int>& tree, vector<int>& squirrel, vector<vector<int>>& nuts) 
    {
        int closestNut = getFirstNut(squirrel, nuts, tree);
        int distance = 0;

        for (int i = 0; i < nuts.size(); ++i) {
            
            if (i != closestNut) {
                distance += (manhattanDistance(tree, nuts[i])*2); 
            }
            else {
                distance += manhattanDistance(squirrel, nuts[i]);
                distance += manhattanDistance(tree, nuts[i]);
            }
        }
        return distance;
    }
};