# Thinking Process 

1. Only the difference between consecutive numbers are important. The max length if a slice is given by
   the number of equal consecutive differences. A slice with max length of L contains L-1 slices of length 3, 
   L-2 slices of length 4, L-3 slices of length 5 and so on. Using this observation we can just itarate the input
   array, find the max length of a slice and comput the total slices.

# Complexity (approach 1)

* O(N) time to iterate through the input array
* O(1) space






