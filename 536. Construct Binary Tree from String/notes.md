# Thinking Process 

1. Use DFS. A node can be recursively built as node = num(L)(R) where L,R = node. Extracting substrings is expensive: better use index to move through the input string. How to converst string to int? stoi is the fast snwer but stoi needs substr. More efficient convert on the fly, but consider corner case of negative values.

Clarification: cannot have node with only right child.

# Complexity (approach 1)

* O(N) time
* O(N) space for the recursion stack






