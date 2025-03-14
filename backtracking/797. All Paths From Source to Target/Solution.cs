public class Solution {
    
    private IList<IList<int>> paths;
    
    public IList<IList<int>> AllPathsSourceTarget(int[][] graph) {
        paths = new List<IList<int>>();
        Dfs(graph, 0, graph.Length-1, new List<int>());
        return paths;
    }
    
    private void Dfs(int[][] graph, int currentNode, int targetNode, IList<int> path) {
        
        path.Add(currentNode);
        if (currentNode == targetNode) {
            paths.Add(new List<int>(path));
        }
        else {           
            foreach (int neighbor in graph[currentNode]) {
                Dfs(graph, neighbor, targetNode, path);
            }
        }
        path.RemoveAt(path.Count-1);
    } 
}
