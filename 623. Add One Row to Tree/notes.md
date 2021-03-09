# Thinking Process 

1. It is convenient to use DFS. For each node at level d-1, create a pair of nodes  with value v and attach these nodes to the current node and to its children according to the rule. The current node becomes the parent of the new ones. The left child of the current node becomes the left child of the left new node and the right child of the current node becomes the right child of the right new node. Corner case the root, handle it separated.

# Complexity (approach 1)

* O(N) time
* O(N) space for recursion stack






