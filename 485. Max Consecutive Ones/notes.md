# Thinking Process 

1. Brute force solution is enough. Just iterate through the input array updating the current number of consecutive 1s and the maximum of them. When a window of consecutive 1s finish (i.e. there is a 0), reset the the current number of consecutive 1s to 0.

# Complexity

* O(N) time to iterate through all the numbers
* O(1) space
