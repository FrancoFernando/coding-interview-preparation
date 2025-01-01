public class Solution {

    Dictionary<int, List<(int vertex, bool isOutgoing)>> graph;
    bool[] visited;

    public int MinReorder(int n, int[][] connections) {
        
        graph = new Dictionary<int, List<(int,bool)>>(n);
        visited = new bool[n];

        foreach (var edge in connections)
        {
            AddEdge(edge[0], edge[1], true);
            AddEdge(edge[1], edge[0], false);
        }
        
        return Dfs(0);
    }

    private void AddEdge(int from, int to, bool isOutgoing) {
        if (!graph.ContainsKey(from)) {
            graph[from] = new List<(int, bool)>();
        }
        graph[from].Add((to, isOutgoing));
    }

    private int Dfs(int vertex) {
        
        if(visited[vertex]) 
            return 0;

        visited[vertex] = true;

        int result = 0;

        foreach(var neighbor in graph[vertex]) {
            if (!visited[neighbor.vertex] && neighbor.isOutgoing)
                result += 1 + Dfs(neighbor.Item1);
            else 
                result += Dfs(neighbor.Item1);
        }

        return result;
    }
}
