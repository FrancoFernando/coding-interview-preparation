# Thinking Process 

1. My first observation is that the missing can be computed using the duplicate, the sum and the sum if it were no duplicate.
   So the problem reduces in finding the duplicate. The duplicate can be found easily using hash set. Since number are from 1 to set size and set size is max 10000 the hash set can be implmented as bitmap.

# Complexity (approach 1)

* O(N) time
* O(N) space for the bitset






