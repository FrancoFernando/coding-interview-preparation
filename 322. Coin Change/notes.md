# Thinking Process 

1. Classic DP problem. Top down approach: find a recursive solution. At each recursive step try 
   to decrement the amount with each available coin. The base cases are amount = 0 that means solution found or amount < 0 the means solution not found. Oberve repeated subproblems: all recursive step starting with the same amount. Use cache.

# TODO

Try bottom up solution and BFS (each node is an amount, tree starting with the initial amount).

# Complexity (approach 1)

* O(NC) time, at each of the N recursive steps all the C coins are tried
* O(N) space to cache the result for each possible amount






