class Solution:
    def allPathsSourceTarget(self, graph: List[List[int]]) -> List[List[int]]:
        def backtrack(node, path):
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
