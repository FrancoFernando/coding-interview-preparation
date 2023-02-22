### Thinking problem

The problem ask to find how many occurrences of the characters in the first string (S1) are in the second string (S2).
The brute force solution is to iterate over the second string a add 1 to the result if this is the first string.
To do this efficiently the characters in the first stra=ing can be inserted in a hash set.

### Complexity

* O(S1+S2) time
* O(S1) space
