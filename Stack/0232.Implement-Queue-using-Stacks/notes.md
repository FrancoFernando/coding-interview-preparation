### Thinking process

Queue is a FIFO structure, stack is LIFO. 
So you can enquee elements in a stack but you can't dequeue them from the same stack. 
But if you move the elements to the second stack they are in the right order for being dequeued in FIFO order.

### Complexity

* O(N) amortized time because an element is moved to the dequeue stack only once
* O(N) spaced
