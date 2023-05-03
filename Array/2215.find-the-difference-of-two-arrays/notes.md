## Thinking process

The problem asks to create a new array that has not the numbers in the intersection between the original array and a second array.
The optimal way to do this is converting the second array to a hash set and iterating through the original array.

## Complexity

* O(N+M) time, where N,M are the length of the 2 arrays
* O(N+M) space
