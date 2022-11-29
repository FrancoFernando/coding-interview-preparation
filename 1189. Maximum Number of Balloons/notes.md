# Thinking Process 

To form the word balloon are necessary 1 occurrence of b,a,n and 2 of o,l. Let's call this expected occurrences.
To get the answer it's necessary to count the occurrence of each character of the given text and see the maximum number of word balloon that can be composed.
This is given by the minimum betweeen the occurrence of each character in text divided by its expected occurrence.

# Complexity

* O(N+A) time to iterate through the input text and the alphabet
* O(A) space (the size of the alphabet)
