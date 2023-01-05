class Solution {
    
    enum class Group {
        None,
        A,
        B
    };
    
    Group assignGroup (Group current) {
        
        return (current == Group::A) ? Group::B : Group::A;
    }
    
    bool dfs(vector<vector<int>> const& graph, int node, vector<Group>& group) {
        
        for (int destNode : graph[node]) {
            //the destination node has been already assigned to the same group: 
            //no bipartite
            if (group[destNode] == group[node]) return false;
            //if destination node has not been already assigned:
            //assign it and recursively explore is neighboor
            if (group[destNode] == Group::None) {
                group[destNode] = assignGroup(group[node]);
                if (!dfs(graph, destNode, group)) return false;
            } 
        }
        return true;
    }
    
public:
    bool isBipartite(vector<vector<int>>& graph) {
        
        vector<Group> group(graph.size(), Group::None);
        for (int i = 0; i < graph.size(); ++i) {
            //this check will pass once for every connected component
            if (group[i] == Group::None) {
                //we can arbitrarily assign to A the first node of each component
                group[i] = Group::A;
                if (!dfs(graph, i, group)) return false;
            }
        }
        return true;
    }
};
