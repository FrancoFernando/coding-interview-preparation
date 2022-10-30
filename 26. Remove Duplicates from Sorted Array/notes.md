# Thinking Process 

Brute force would be to use an extra array to copy elements, but it's required to do without extra memory.
The key observation is noticing that the final position of each element is shifted to the left by the number of duplicates already encountered.
 

# Complexity

* O(N) time to iterate through the array
* O(1) space
