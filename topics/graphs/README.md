# Graphs

## Overview

Graphs consist of vertices (nodes) connected by edges. They can be directed/undirected and weighted/unweighted.

## Key Concepts

- **Adjacency List**: Space-efficient for sparse graphs O(V + E)
- **Adjacency Matrix**: O(1) edge lookup but O(V²) space
- **DFS (Depth-First Search)**: Explore as far as possible before backtracking
- **BFS (Breadth-First Search)**: Explore level by level
- **Topological Sort**: Linear ordering of DAG vertices
- **Connected Components**: Groups of connected vertices

## Common Patterns

1. **DFS/BFS Traversal** - Basic graph exploration
2. **Cycle Detection** - Using colors or visited sets
3. **Shortest Path** - BFS (unweighted), Dijkstra (weighted)
4. **Topological Sort** - Kahn's algorithm, DFS-based
5. **Union-Find** - Disjoint set operations
6. **Minimum Spanning Tree** - Kruskal's, Prim's

## Time Complexities

| Algorithm | Time |
|-----------|------|
| DFS/BFS | O(V + E) |
| Dijkstra | O((V + E) log V) |
| Bellman-Ford | O(V × E) |
| Floyd-Warshall | O(V³) |
| Topological Sort | O(V + E) |

## Notes

[Add your study notes here]
