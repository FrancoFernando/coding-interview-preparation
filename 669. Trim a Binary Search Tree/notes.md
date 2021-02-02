# Thinking Process 

1. The first idea is to use DFS. Let's call n the curent node and use BST property. 
   If n > low AND n < high we con continue the recursion and return n
   If n < low we can exclude n->left and continue recursion only on n->right
   If n > high we can exclude n->right and continue recursion only on n->left

# Complexity (approach 1)

* O(N) time
* O(N) space for the recursion stack






