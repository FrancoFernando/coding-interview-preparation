### Thinking Process

The problem asks to process a string of parentheses and chack that they match in the correct order.
The nature of the problem bring to process charcters in LIFO order. 

If the current character is a closed brackets it should match with the last inserted open brackets. 
Using a stack is natural to this problem.

Instead of hardcoding brackets into the code, a more elegant solution is to encode the correspondences between open and closed bracket into a dictionary.

### Complexity 

* O(N) time
* O(N) space


