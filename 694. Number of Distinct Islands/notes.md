# Thinking Process 

1. The problem is a variation of number of island, so it is a graph matrix problem and can be solved using DFS or BFS.
   The difference is that island having the same shape (equal after translation) should not be counted multiple times.
   This bring immediately to the idea of using hash set to remove duplicates. It is necessary a signature to uniquely
   identify a shape. The path used to discover the island in DFS can be used as signature but for each cell it is necessary
   to mark both entry and exit direction, otherwise would be not unique.

# Complexity (approach 1)

* O(NM) time since each cell is explored
* O(NM) space for the signature






