## Thinking process

The brute force approach would be to iterate all the possible substrings of length k and check the max number of vowels.
But that's a lot of repeated work.
A better approach requires sliding window. You keep a window of size k and keep updated the number of vowels in it as the window move through the string.

## Complexity

* O(N) time complexity to move the windows through the string
* O(1) space
