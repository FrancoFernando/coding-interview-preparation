# Thinking Process 

Brute force is to compute the average for each subarray.That's a lot of repeated work.
Best approach is using a sliding windows keeping a running sum of values and updating the sum 
in constant time as the window moves.

# Complexity

* O(N) time to move the window through all the input array
* O(1) space
