### Thinking process

Queue is a FIFO structure, stack is LIFO. 
So you can push elements in a queue but you can't pop them from the same queue. 
But if you move all the elements but one to the second queue, you get the element to pop.

### Complexity

* O(1) to push and O(N) time to pop because wvery pop operation requires to move all the elements
* O(N) space
