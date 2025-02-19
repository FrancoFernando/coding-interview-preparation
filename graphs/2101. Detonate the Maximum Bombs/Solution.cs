public class Solution {
    public int MaximumDetonation(int[][] bombs) {
        
		int maxBombs = 0;
		int n = bombs.Length;
		var graph = BuildGraph(bombs);
		
		for (int i = 0; i < n; i++) {
			var visited = new BitArray(n);
			maxBombs = Math.Max(maxBombs, Dfs(graph, i, visited));
			if (maxBombs == n) break;
		}
		return maxBombs;	
    }
	
	private int Dfs(List<int>[] graph, int nodeIndex, BitArray visited) {
		
		int reachedNodes = 1;
		visited[nodeIndex] = true;
		foreach (var adjacent in graph[nodeIndex]) {
			if (!visited[adjacent]) {
				reachedNodes += Dfs(graph, adjacent, visited);
			}
		}
		return reachedNodes;
	}
	
	private List<int>[] BuildGraph(int[][] bombs) {
	  
		int n = bombs.Length;
		var graph = new List<int>[n];
		
		for (int i = 0; i < n; i++) {
			graph[i] = new List<int>();
			for (int j = 0; j < n; j++) {
				if (i != j && CanDetonate(bombs[i], bombs[j])) {
                    graph[i].Add(j);
                }
			}
		}
		
		return graph;
	}
	
	private bool CanDetonate(int[] bomb1, int[] bomb2) {
        long dx = bomb1[0] - bomb2[0];
        long dy = bomb1[1] - bomb2[1];
        long r = bomb1[2];
        return dx * dx + dy * dy <= r * r;
    }
}
