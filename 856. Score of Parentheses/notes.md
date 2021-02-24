# Thinking Process 

1. The problem remainded me to nested linked list. Each pair of parenthesis belongs to a depth level. 
   The rules are: 1) score of the same level are summed; 2) when a level is closed 2 times the score of the nested 
   level is added to the current level score. A counter of the current level and an array used as hash table to store level scores
   are enough.

# Complexity (approach 1)

* O(N) time to iterate through the string
* O(N) space for the array keeping the level scores






