# Thinking Process 

Brute force is to check every possible sequence on O(N2). Better is using sliding windown approach mantaining one invariant: at maximum a 0 can be in the windows.
This gives O(N) solution. To adapt the algorithm to a stream, just use a last zero index instead concept instead of num of zeroes.

# Complexity

* O(N) time to iterate through the input
* O(1) space

