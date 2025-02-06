public class Solution {
    private HashSet<int> _restrictedSet;

    public int ReachableNodes(int n, int[][] edges, int[] restricted) {
        var tree = BuildTree(n, edges);
        _restrictedSet = new HashSet<int>(restricted);
        return Dfs(tree, 0, -1);
    }

    private int Dfs(List<int>[] tree, int node, int parent) {
        if (_restrictedSet.Contains(node)) {
            return 0;
        }

        int reachable = 1;
        foreach (var adjacent in tree[node]) {
            if (adjacent != parent) {
                reachable += Dfs(tree, adjacent, node);
            }
        }
        return reachable;
    }

    private List<int>[] BuildTree(int n, int[][] edges) {
        var tree = new List<int>[n];
        for (int i = 0; i < n; i++) {
            tree[i] = new List<int>();
        }

        foreach (var edge in edges) {
            tree[edge[0]].Add(edge[1]);
            tree[edge[1]].Add(edge[0]);
        }
        return tree;
    } 
}
