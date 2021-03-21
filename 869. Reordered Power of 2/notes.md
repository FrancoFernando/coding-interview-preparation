# Thinking Process 

1. Generate all possible permotation and check if one of them is a power of 2 is the BF approach. The limit is that the number of possible permutations is much more then the power od 2 (only 32 for integers). So reverse the problem. Generate a signature for each power of 2 and check if this signature correspond to the one of the input number.

# Complexity (approach 1)

* O(logN) time to generate the signature
* O(1) space (space for the signature is equal to number of digits)






