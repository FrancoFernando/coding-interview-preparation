# Thinking Process 

1. First thing to observe is that graph is already represented as adjacency list. Second thing is that graph can have more disconnected components. If a graph is bipartite every node of a component is connected only to nodes belonging to the other group.
A graph coloring problem that can be solved using both dfs or bfs. Assign a node to a group and check if the adjacent nodes has not already been assigned to the same group.

2. TODO: try bfs implementation and dfs with explicit stack.

# Complexity (approach 1)

* O(V+E) time, since we need to color all nodes and explore all edges
* O(V) space to store group information






