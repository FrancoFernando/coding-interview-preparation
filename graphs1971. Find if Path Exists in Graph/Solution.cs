public class Solution {
    public bool ValidPath(int n, int[][] edges, int source, int destination) {
        
        var graph = BuildGraph(n, edges);
        var visited = new bool[n];
        return Dfs(graph, source, destination, visited);
    }
    
    private bool Dfs(IList<int>[] graph, int vertex, int destination, bool[] visited) {
        
        if (vertex == destination) {
            return true;
        }
        
        visited[vertex] = true;
        
        foreach (int adjacent in graph[vertex]) {
            if (!visited[adjacent] && Dfs(graph, adjacent, destination, visited)) {
                    return true;
            }
        }
        
        return false;
    }
    
    private List<int>[] BuildGraph(int n, int[][] edges) {
        var graph = new List<int>[n];
        for (int i = 0; i < n; i++) {
            graph[i] = new List<int>();
        }
        
        foreach (var edge in edges) {
            graph[edge[0]].Add(edge[1]);
            graph[edge[1]].Add(edge[0]);
        }
        
        return graph;
    }
}
