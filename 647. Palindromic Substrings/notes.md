# Thinking Process 

1. The idea is that each letter can be the mid one of an odd-length palindrome or one of the two mid one of an even length palindrome. Try this for every letter of the string and mark all the combination starting with a pair of letters to avoid duplicate computation for even length palindrome.

# TODO
* try pure DP solution
* it seems there are more efficient solutions, try to understand them

# Complexity 

* O(N^2) time since every substring is iteratated once
* O(N^2) space to mark the already counted combinations






