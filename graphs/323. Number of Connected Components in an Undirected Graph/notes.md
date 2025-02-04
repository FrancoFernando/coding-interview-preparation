# Description

You have a graph of n nodes. You are given an integer n and an array edges where edges[i] = [ai, bi] indicates that there is an edge between ai and bi in the graph.

Return the number of connected components in the graph.

 

Example 1:


Input: n = 5, edges = [[0,1],[1,2],[3,4]]
Output: 2
Example 2:


Input: n = 5, edges = [[0,1],[1,2],[2,3],[3,4]]
Output: 1
 

Constraints:

1 <= n <= 2000
1 <= edges.length <= 5000
edges[i].length == 2
0 <= ai <= bi < n
ai != bi
There are no repeated edges.

# Though Process

The problem can be solved by running dfs algo on all the graph vertices. Every time you start a dfs on an unvisited node, you discover a new component.

# Complexity 

 The time complexity is O(V + E), where V is the number of vertices and E is the number of edges. The space complexity is also O(V + E) for the graph representation and the visited array.
