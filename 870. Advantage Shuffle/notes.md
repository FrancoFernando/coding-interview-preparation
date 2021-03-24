# Thinking Process 

1. Generate all possible permotation and find the one maximizing A advantage is the BF approach. However it is not necessary to generate all permutation. Trying to solve manually the problem with small example show that the right approach is greedy. What would you do manually is pair each element of b in B with the first element a in A that a > b. Sorting the two vector allow to do this in one pass with a two pointer approach. While sorting B it is necessary to keep their original position so that it is possible to place element of A accordingly.

# Complexity (approach 1)

* O(NlogN) time to sort A and B
* O(1) space 






