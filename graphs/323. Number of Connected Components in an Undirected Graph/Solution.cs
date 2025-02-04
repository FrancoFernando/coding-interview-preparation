public class Solution {
    public int CountComponents(int n, int[][] edges) {      
        var graph = BuildGraph(n, edges);
        var visited = new bool[n];
        int components = 0;
        for (int i = 0; i < n; i++) {
            if (!visited[i]) {
                components += 1;
                Dfs(graph, i, visited);
            }
        }
        return components;
    }
    
    private void Dfs(List<int>[] graph, int node, bool[] visited) {
        
        visited[node] = true;
        foreach (int adjacent in graph[node]) { 
            if (!visited[adjacent]) {
                Dfs(graph, adjacent, visited);
            }
        }
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
