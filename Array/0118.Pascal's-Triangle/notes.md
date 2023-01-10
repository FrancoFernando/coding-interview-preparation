### Thinking process

The problem is straightforward but it requires to properly handle indexes boundaries.
Two approaches are possible:
1) follow the definition and get each number as sum of the one above left and the one above right
2) reverse the definition letting each number contributing to the one below left and right

## Complexity

* The time complexity is O(N^2) where N is the number of rows (in the last row we need to fill N elements)
* The space complexity is O(1)
