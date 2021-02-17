# Thinking Process 

1. Brute force is to compute the max area between each pair of lines and keep the max O(N^2). Optimal solution is to compute
   the max area between the leftmost line and the rightmostline. Then take the lower of these lines and considering the next one.
   Use two pointer approach until the window has only one line. 

# Complexity (approach 1)

* O(N) time to iterate through all the lines
* O(1) space






