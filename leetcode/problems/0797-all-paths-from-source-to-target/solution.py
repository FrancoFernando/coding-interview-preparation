"""
LeetCode #797: All Paths From Source to Target
Difficulty: Medium
Link: https://leetcode.com/problems/all-paths-from-source-to-target/
"""
from typing import List


class Solution:
    def allPathsSourceTarget(self, graph: List[List[int]]) -> List[List[int]]:
        def backtrack(node: int, path: List[int]):
            if node == len(graph) - 1:
                result.append(path[:])
                return
            for next_node in graph[node]:
                path.append(next_node)
                backtrack(next_node, path)
                path.pop()

        result = []
        backtrack(0, [0])
        return result
