public class Solution {

    //queries = paths from from start to end
    //values = weights
    //equations = edges

    Dictionary<string, List<(string, double)>> graph;

    public double[] CalcEquation(IList<IList<string>> equations, double[] values, IList<IList<string>> queries) {
        
        graph = new Dictionary<string, List<(string, double)>>();
        BuildGraph(equations, values);

        var result = new double[queries.Count];
        for (int i = 0; i < queries.Count; ++i) {
            result[i] = CalcQuery(queries[i][0], queries[i][1]);
        }
        return result;
    }

    private void BuildGraph(IList<IList<string>> equations, double[] values) {
        for (int i = 0; i < equations.Count; i++) {
            var (from, to) = (equations[i][0], equations[i][1]);
            AddEdge(from, to, values[i]);
            AddEdge(to, from, 1 / values[i]);
        }
    }

    private void AddEdge(string from, string to, double weight) {
        if (!graph.TryGetValue(from, out var neighbors)) {
            neighbors = new List<(string, double)>();
            graph[from] = neighbors;
        }
        neighbors.Add((to, weight));
    }

    private double CalcQuery(string start, string end) {
        if (!graph.ContainsKey(start) || !graph.ContainsKey(end)) {
            return -1.0;
        }
        
        var visited = new HashSet<string>();
        return Dfs(start, end, visited);
    }

    private double Dfs(string current, string end, HashSet<string> visited) {

        if (current == end) {
            return 1.0;
        }

        visited.Add(current);

        foreach(var (neighbor, weight) in graph[current]) {
            if(!visited.Contains(neighbor)) {
                var result = Dfs(neighbor, end, visited);
                if(result >= 0) 
                    return weight * result;
            }   
        }
        visited.Remove(current);
        return -1.0;
    }
}
