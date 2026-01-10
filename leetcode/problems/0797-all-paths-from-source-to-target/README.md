# 797. All Paths From Source to Target

**Difficulty:** Medium
**Link:** [LeetCode](https://leetcode.com/problems/all-paths-from-source-to-target/)

## Problem Description

Given a directed acyclic graph (DAG) of n nodes labeled from 0 to n - 1, find all possible paths from node 0 to node n - 1 and return them in any order.

The graph is given as follows: graph[i] is a list of all nodes you can visit from node i.

Example 1:

Input: graph = [[1,2],[3],[3],[]]
Output: [[0,1,3],[0,2,3]]

Example 2:

Input: graph = [[4,3,1],[3,2,4],[3],[4],[]]
Output: [[0,4],[0,3,4],[0,1,3,4],[0,1,2,3,4],[0,1,4]]

Constraints:

n == graph.length
2 <= n <= 15
0 <= graph[i][j] < n
graph[i][j] != i (i.e., there will be no self-loops).
All the elements of graph[i] are unique.
The input graph is guaranteed to be a DAG.

## Approach

Use DFS and backtrack every time you reach the end node.
It's not necessary to keep track of the visited nodes since each node may need to be visited multiple times and the graph is a DAG.

## Complexity

- **Time Complexity:** O(2^N * N) in the worst case, where N is the number of nodes
- **Space Complexity:** O(N) for the recursion stack and path storage
