# Thinking Process 

It's a simple extension of the previous problems. Brute force is to check every possible sequence on O(N2). Better is using sliding windown approach mantaining one invariant: at maximum k zeros can be in the windows.
This gives O(N) solution.

# Complexity

* O(N) time to iterate through the input
* O(1) space
