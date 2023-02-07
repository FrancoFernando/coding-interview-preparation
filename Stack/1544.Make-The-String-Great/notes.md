### Thinking Process

The problem asks to process a string and remove all close pairs of equal characters with different case. 
The nature of the problem bring to process charcters in LIFO order.
If the current character is a lowercase (uppercase) and the previous character is the same uppercase (lowercase), both can be removed. 

Using a stack is natural to this problem.

### Complexity

O(N) time
O(N) space (with explicit stack)
