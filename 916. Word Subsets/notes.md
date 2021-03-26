# Thinking Process 

1. Every word b in B shall be generated using the letters a in A so that a is universal. The ideal solution would check each word a in A only one to know if it is universal or not. Build a global signature for all b words in B containing the max frequency of each letter. Compare the signature against each word as in A.

# Complexity 

* O(N+M) time where N are the words in A and M the words in B
* O(1) space for the signature since alphabet is constant and equal to 26






